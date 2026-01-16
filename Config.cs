using Exiled.API.Interfaces;
using System.ComponentModel;

namespace TimerSystem
{
    public class Config : IConfig
    {
        [Description("Enable/Disable plugin")]
        public bool IsEnabled { get; set; } = true;

        [Description("Enable/Disable debug")]
        public bool Debug { get; set; } = false;

        [Description("How will the «Round Time» be displayed in the HEX code?")]
        public string ColorTime { get; set; } = "<color=#ffffff>";

        [Description("What colors will the «Server» be displayed in the HEX code?")]
        public string ColorServer { get; set; } = "<color=#ffffff>";

        [Description("Server Name")]
        public string NameServer { get; set; } = "My server Name";

        [Description("Enable/Disable reloading configs")]
        public bool ReConfig { get; set; } = true;
    }
}