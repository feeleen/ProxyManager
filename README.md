# Proxy Manager

A lightweight Windows application for managing system proxy settings with profile support.

![License](https://img.shields.io/badge/license-MIT-blue.svg)
![.NET](https://img.shields.io/badge/.NET-10.0-purple.svg)
![Platform](https://img.shields.io/badge/platform-Windows-lightgrey.svg)

## Features

<img width="589" height="502" alt="image" src="https://github.com/user-attachments/assets/ff3bdfd6-533b-4ace-b6d1-aa89b98fad1c" />

### 🔧 Proxy Configuration
- **Automatic detection** - Automatically detect proxy settings
- **PAC Script support** - Use automatic configuration scripts
- **Manual proxy setup** - Configure custom proxy server address and port
- **Bypass list** - Specify addresses that should bypass the proxy

### 📁 Profile Management
- **Save profiles** - Store multiple proxy configurations
- **Quick switch** - Load saved profiles from tray menu or main menu
- **Delete profiles** - Remove unused configurations
- **ComboBox selection** - Choose existing profile or create new one when saving

### 🚀 System Integration
- **System tray icon** - Quick access to all functions
- **Run at startup** - Auto-start with Windows
- **Minimize to tray** - Close to tray instead of exiting
- **Context menu** - Full control from system tray

### 🧪 Proxy Testing
- **Test connection** - Verify proxy connectivity
- **Response logging** - View detailed response information

## Installation

### Requirements
- Windows 10/11
- .NET 10.0 Runtime
- Administrator rights may be required for some system settings

### Steps
1. Download the latest release
2. Extract to desired location
3. Run `ProxyManager.exe`

## Usage

### Configure Proxy
1. Open **Proxy Settings** tab
2. Configure your proxy settings:
   - Enable automatic detection
   - Enter PAC script URL
   - Set proxy server address
   - Configure bypass list
3. Click **Apply** to save settings

### Save Profile
1. Configure your proxy settings
2. Click **Save Profile**
3. Enter a name or select existing profile to overwrite
4. Click **OK**

### Load Profile
- From main menu: **Profiles** → Select profile
- From tray: Right-click tray icon → **Profiles** → Select profile

### Enable/Disable Proxy
- From main menu: **Proxy** → **Use proxy server**
- From tray: Right-click tray icon → **Use proxy server**

### Run at Startup
1. Go to **Settings** → **Run at startup**
2. Check/uncheck to enable/disable

## File Locations

- **Profiles**: `%LOCALAPPDATA%\ProxyManager\profiles.json`
