$UI = (Get-Host).UI.RawUI
$UI.BackgroundColor = "Black"
$UI.ForegroundColor = "Green"
Set-Service wuauserv -StartupType "Automatic"
Start-Service -DisplayName "Windows Update"