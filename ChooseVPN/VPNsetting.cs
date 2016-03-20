using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChooseVPN
{
    public partial class VPNsetting : Form
    {
        private OpenVpnClass _VPC;
        public VPNsetting(OpenVpnClass VPC)
        {
            InitializeComponent();
            _VPC = VPC;
        }


        private void folder_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void VPNsetting_Load(object sender, EventArgs e)
        {
            textBox1.Text = ConfigurationManager.AppSettings["OpenvpnSite"];
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "openvpn|openvpn.exe|All|*.*";
        }

        private void VPNsetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            _VPC.Filepath=textBox1.Text;
            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            cfa.AppSettings.Settings["OpenvpnSite"].Value = textBox1.Text;
            cfa.Save();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBox1.Text = openFileDialog1.FileName;
        }
    }
}
