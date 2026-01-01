# Chrome++ Next
[![LICENSE](https://img.shields.io/badge/License-GPL--3.0--only-blue.svg?style=for-the-badge&logo=github "LICENSE")](https://github.com/Bush2021/chrome_plus/blob/main/LICENSE) [![LAST COMMIT](https://img.shields.io/github/last-commit/Bush2021/chrome_plus?color=blue&logo=github&style=for-the-badge "LAST COMMIT")](https://github.com/Bush2021/chrome_plus/commits/main)  [![STARS](https://img.shields.io/github/stars/Bush2021/chrome_plus?color=brightgreen&logo=github&style=for-the-badge "STARS")](https://github.com/Bush2021/chrome_plus/stargazers) ![SIZES](https://img.shields.io/github/languages/code-size/Bush2021/chrome_plus?color=brightgreen&logo=github&style=for-the-badge "SIZES")

English | [简体中文](README_CN.md)

## Features
* Double-click to close tab.
* Right-click to close tab (hold Shift to show the original menu).
* Preserve the last tab (prevent the browser from closing when the last tab is closed).
* Use the mouse wheel to switch tabs when hovering over the tab bar.
* Use the mouse wheel to switch tabs when holding the right mouse button.
* Create new tab to opens the contents entered in address bar (can be configured to open in foreground or background).
* Create new tab to opens bookmarks (can be configured to open in foreground or background).
* Disable the above two features when the current tab is a new tab.
* Customize hotkeys to quickly hide the browser window (boss key).
* Customize hotkeys to translate web page.
* Key mapping: Remap keyboard shortcuts to other keys or Chrome commands.
* Portable design (incompatible with the original data; you can reinstall the system or change computers without losing data).
* Allow custom Chromium command line switches.
* For more features, see [INI configuration file](src/chrome++.ini).

## Download
Built and released automatically using GitHub Actions. Download link: https://github.com/Bush2021/chrome_plus/releases/.

## Installation
Please make sure to put `version.dll` in the same directory as `chrome.exe`. It's recommended to download the [Chrome offline installer package](https://github.com/Bush2021/chrome_installer), extract it twice to get the Chrome program files, and then place them in the [App](https://github.com/Bush2021/chrome_plus/releases/latest) folder.

## Compatibility
* All browsers based on the latest stable branches of Chromium are theoretically supported.
* Only the latest stable version of Chrome is tested, and maintenance is not guaranteed.
* If the DLL is not properly loaded, try to [set DLL](https://github.com/Bush2021/setdll/).

## Configuration GUI (ChromePlusGUI)
A Windows Forms configuration utility is available under `ChromePlusGUI/`. It stores user settings in `%APPDATA%\ChromePlusGUI\settings.json` and keeps logs in `%APPDATA%\ChromePlusGUI\logs\config_gui.log`.

* Auto-detects `chrome.exe`/`comet.exe` in common install paths, next to the GUI executable, and on `PATH`; a manual **Browse** picker is also available.
* Tabs cover portability, tab enhancements, Chrome flags, performance, and security toggles.
* Saves use atomic JSON writes and validation (executable must exist and be a valid PE file). A reset action restores defaults, and a collapsible log viewer is built in.
* Run on Windows with `dotnet run --project ChromePlusGUI/ChromePlusGUI.csproj` (targets .NET 8 Windows; `EnableWindowsTargeting` is set for cross-restore).

### Settings format
The JSON file uses camelCase keys and matches the DLL-injection settings surface. Example:

```json
{
  "targetExecutable": "chrome.exe",
  "executablePath": "C:\\\\Program Files\\\\Google\\\\Chrome\\\\Application\\\\chrome.exe",
  "settings": {
    "portabilityMode": {
      "enabled": false,
      "tempDirectory": "%APPDATA%\\\\ChromePlusGUI\\\\Temp",
      "dataLocation": "%APPDATA%\\\\ChromePlusGUI\\\\Data"
    },
    "tabEnhancements": {
      "customTabColors": false,
      "tabGrouping": true,
      "sessionRestore": true,
      "wheelSwitching": true
    },
    "chromeFlags": {
      "flags": [
        "--enable-features=TabGroups"
      ]
    },
    "performance": {
      "memoryLimitMb": 0,
      "disableCache": false,
      "disableExtensions": false
    },
    "security": {
      "adBlocking": false,
      "trackingPrevention": false,
      "scriptSandboxing": true
    }
  },
  "lastModified": "2026-01-01T00:00:00Z",
  "version": "1.0"
}
```

## License
* Versions 1.5.4 and earlier are licensed under MIT license, with all rights reserved by [Shuax](https://github.com/shuax/).
* Version 1.5.5 - 1.5.9 are licensed under MIT license, with modifications made by contributors to this repository based on Shuax's version.
* Versions 1.6.0 and later are licensed under [GPL-3.0 license](LICENSE).

## Thanks
* All [contributors](https://github.com/Bush2021/chrome_plus/graphs/contributors)
* Original Author [Shuax](https://github.com/shuax/)
* Revision code [provider](https://forum.ru-board.com/topic.cgi?forum=5&topic=51073&start=620&limit=1&m=1#1) for version 1.5.5
* [面向大海](https://github.com/mxdh/)
* [Ho Cheung](https://github.com/gz83/)
