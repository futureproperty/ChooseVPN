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
using ChooseVPN;

namespace ChooseVPN
{
    public partial class Proxysetting : Form
    {
        private Main _mainform;

        public Proxysetting(Main mainform)
        {
            InitializeComponent();
            _mainform = mainform;
        }


        private void UseProxyFlag_CheckedChanged(object sender, EventArgs e)
        {
            if (UseProxyFlag.Checked == false)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
        }

        private void Proxysetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            cfa.AppSettings.Settings["host"].Value = textBox1.Text;
            cfa.AppSettings.Settings["port"].Value = textBox2.Text;
            cfa.AppSettings.Settings["flag"].Value = UseProxyFlag.Checked.ToString();
            cfa.Save();
            _mainform.vpncsv.SetPorxy(textBox1.Text, Int32.Parse(textBox2.Text),
                !UseSystemProxyFlag.Checked && UseProxyFlag.Checked);
        }

        private void Proxysetting_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["flag"] == "False") UseProxyFlag.Checked = false;
            else UseProxyFlag.Checked = true;
            textBox1.Text = ConfigurationManager.AppSettings["host"];
            textBox2.Text = ConfigurationManager.AppSettings["port"];
            UseProxyFlag.Checked = _mainform.vpncsv.ProxyFlag;
            if (UseProxyFlag.Checked == false)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
            else
            {
                string httpproxy = _mainform.vpncsv.Proxy.Address.ToString();
                string[] parts1 = httpproxy.Split('/');
                string[] parts2 = parts1[2].Split(':');
                string host = parts2[0];
                string port = parts2[1];
                textBox1.Text = host;
                textBox2.Text = port;
            }
        }
    }
}