using Exiled.Events.EventArgs.Server;
using Exiled.API.Features;
using Exiled.Loader;
using MEC;
using System;
using System.Collections.Generic;

namespace TimerSystem
{
    public class CommandsSystem : Plugin<Config>
    {
        public override string Name { get; } = "TimerSystem";
        public override string Author { get; } = "Minasik (discord: minasik)";
        public override System.Version Version { get; } = new Version(1, 0, 0);

        public CoroutineHandle coroutine = new CoroutineHandle();

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Server.WaitingForPlayers += Waiting;
            Exiled.Events.Handlers.Server.RoundStarted += OnStarted;
            Exiled.Events.Handlers.Server.RoundEnded += OnEnded;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.WaitingForPlayers -= Waiting;
            Exiled.Events.Handlers.Server.RoundStarted -= OnStarted;
            Exiled.Events.Handlers.Server.RoundEnded -= OnEnded;

            base.OnDisabled();
        }

        public void Waiting()
        {
            Timing.KillCoroutines(coroutine);
        }

        public void OnStarted()
        {
            coroutine = Timing.RunCoroutine(classiccor());
        }

        public IEnumerator<float> classiccor()
        {
            while (true)
            {
                int i = 0;
                try
                {
                    var timedd = DateTime.Now - Round.StartedTime;
                    var strtime = "";
                    i = 1;
                    var minutes = timedd.Minutes < 10 ? $"0{timedd.Minutes}" : $"{timedd.Minutes}";
                    var seconds = timedd.Seconds < 10 ? $"0{timedd.Seconds}" : $"{timedd.Seconds}";
                    i = 2;
                    if (timedd.Hours != 0) strtime += timedd.Hours < 10 ? $"0{timedd.Hours}:" : $"{timedd.Hours}:";
                    strtime += $"{minutes}:{seconds}";
                    foreach (Player pl in Player.List)
                    {
                        if (pl.IsDead)
                        {
                            i = 6;
                            pl.ShowHint($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n<align=\"left\"><size=20pt>           {Config.ColorTime}Время раунда:</color> <color=#FFFFFF>{strtime}</color>\n           {Config.ColorServer}Сервер:</color> {Config.NameServer}</color>", 1.2f);
                        }
                        else
                        {
                            i = 7;
                            pl.ShowHint($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n<align=\"left\"><size=20pt>           {Config.ColorTime}Время раунда:</color> <color=#FFFFFF>{strtime}</color>\n           {Config.ColorServer}Сервер:</color> {Config.NameServer}</color>", 1.2f);
                        }
                    }
                }
                catch (Exception e)
                {
                    Log.Error($"{e}\n\nError: {i}");
                }
                yield return Timing.WaitForSeconds(1f);
            }
        }

        public void OnEnded(RoundEndedEventArgs ev)
        {
            if (Config.ReConfig == true)
            {
                ConfigManager.ReloadRemoteAdmin();
                ConfigManager.Reload();
                Log.SendRaw($"Config's reload...", ConsoleColor.Blue);
            }
            else
            {
                Log.SendRaw($"Reload config's is disabled!", ConsoleColor.Blue);
            }
        }
    }
}