$UI = (Get-Host).UI.RawUI
$UI.BackgroundColor = "Black"
$UI.ForegroundColor = "Green"
Set-Service wuauserv -StartupType "Disabled"
Stop-Service -DisplayName "Windows Update"