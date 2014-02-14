using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Windows_Installer_Toggle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button_off_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("PsExec Stop-WindowsInstallerService.bat");
        }
        private void button_on_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("PsExec Start-WindowsInstallerService.bat");
        }
    }
}