```markdown
# TimerSystem

A lightweight plugin for SCP: Secret Laboratory that displays round time and server name to all players. Built using the EXILED framework.

## 📋 Features

- **Real-time Round Timer** - Displays elapsed time since round start (HH:MM:SS format)
- **Custom Server Name** - Show your server's name to all connected players
- **Fully Customizable** - Change colors and text via config
- **Automatic Updates** - Timer updates every second
- **Config Auto-Reload** - Optional config reloading at round end
- **Death Compatibility** - Works for both alive and dead players

## 🚀 Installation

### Prerequisites
- [EXILED Framework](https://github.com/ExMod-Team/EXILED/releases) installed on your SCP:SL server

### Installation Steps
1. Download the latest `TimerSystem.dll` from [Releases](https://github.com/MinasikDo/TimerSystem/releases)
2. Place the DLL in your server's `EXILED/Plugins` directory
3. Restart your server via Remote Admin Console or Server Console:
   ```bash
   SR
   ```

## ⚙️ Configuration
After first run, a config file will be generated at:
`EXILED/Configs/(your-server-port)/TimerSystem.yml`

### Default Configuration
```yaml
timer_system:
  # Enable/Disable plugin
  is_enabled: true
  # Enable/Disable debug mode
  debug: false
  # HEX color code for "Round Time" text
  color_time: <color=#ffffff>
  # HEX color code for "Server" text
  color_server: <color=#ffffff>
  # Server display name
  name_server: My Server Name
  # Auto-reload configs at round end
  re_config: true
```

### Configuration Options

| Option | Type | Default | Description |
|--------|------|---------|-------------|
| `is_enabled` | bool | `true` | Enable or disable the plugin |
| `debug` | bool | `false` | Enable debug logging for troubleshooting |
| `color_time` | string | `"<color=#ffffff>"` | HEX color for "Round Time" label |
| `color_server` | string | `"<color=#ffffff>"` | HEX color for "Server" label |
| `name_server` | string | `"My Server Name"` | Your server's display name |
| `re_config` | bool | `true` | Auto-reload all configs when round ends |

## 🔧 Manual Compilation
### Requirements
- .NET Framework 4.7.2 or higher
- EXILED Framework references
- Visual Studio 2022 or similar IDE

### Project Structure
```
TimerSystem/
├── Config.cs        # Configuration class
├── Main.cs          # Main plugin logic
├── TimerSystem.csproj # Project file
└── README.md        # This file
```

## 🐛 Troubleshooting
### Common Issues

| Issue | Solution |
|-------|----------|
| Plugin not loading | Ensure EXILED is installed correctly and DLL is in `EXILED/Plugins` |
| Text not displaying | Check if plugin is enabled in config (`is_enabled: true`) |
| Wrong colors | Verify HEX format is correct: `<color=#RRGGBB>` |
| Timer not updating | Check server logs for errors; enable debug mode |

### Debug Mode
Enable debug mode in config to get detailed logs:
```yaml
timer_system:
  debug: true
  # ... other settings
```

## ⚠️ Disclaimer
This plugin is not affiliated with or endorsed by the official SCP: Secret Laboratory development team. Use at your own risk on multiplayer servers.

⭐ **If you find this plugin useful, please consider giving it a star!**
