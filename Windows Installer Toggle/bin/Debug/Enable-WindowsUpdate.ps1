$UI = (Get-Host).UI.RawUI
$UI.BackgroundColor = "Black"
$UI.ForegroundColor = "Green"
New-ItemProperty 'HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\Auto Update'-Name 'AUOptions'-Value '4' -PropertyType "DWord" -Force