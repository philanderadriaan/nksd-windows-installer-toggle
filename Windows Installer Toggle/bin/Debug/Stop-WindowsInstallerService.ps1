$UI = (Get-Host).UI.RawUI
$UI.BackgroundColor = "Black"
$UI.ForegroundColor = "Green"
Stop-Service -DisplayName "Windows Installer"