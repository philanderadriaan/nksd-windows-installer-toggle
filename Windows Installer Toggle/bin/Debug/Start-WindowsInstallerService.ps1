$UI = (Get-Host).UI.RawUI
$UI.BackgroundColor = "Black"
$UI.ForegroundColor = "Green"
Start-Service -DisplayName "Windows Installer"