using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChooseVPN
{
    public partial class Main : Form
    {
        Thread PingThread;
        public VPNdataClass vpncsv;
        private OpenVpnClass openVpn;


        public Main()
        {
            InitializeComponent();
            vpncsv = new VPNdataClass(false, "127.0.0.1", 8087);
            vpncsv.ReadCsv();
            openVpn = new OpenVpnClass();
            dataGridView1.DataSource = vpncsv.Vpndata;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (PingThread != null && PingThread.IsAlive) PingThread.Abort();
            Thread updataThread = new Thread(VpndataUpdate);
            updataThread.Start();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (PingThread != null && PingThread.IsAlive) PingThread.Abort();
            PingThread = new Thread(LocalPingThread);
            PingThread.IsBackground = true;
            PingThread.Start();
        }

        private void LocalPingThread()
        {
            vpncsv.clearLocalPing();
            vpncsv.LocalPing();
        }

        private void VpndataUpdate()
        {
            vpncsv.clearLocalPing();
            vpncsv.DownloadCsv();
            vpncsv.ReadCsv();
            dataGridView1.Invoke(new Action(() => dataGridView1.DataSource = vpncsv.Vpndata));
            //dataGridView1.Refresh();
            //dataGridView1.DataSource = vpncsv.Vpndata;
        }

        private void ProxySetting_Click(object sender, EventArgs e)
        {
            Proxysetting PSF=new Proxysetting(this);
            PSF.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }


        private void DataGridView1_CellMouseClick(Object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dv=sender as DataGridView;
            if (e.Button == MouseButtons.Right)
            {
                if (dv != null && dv.CurrentRow != null && dv.CurrentRow.Index != -1)
                {
                    Point p = new Point(e.X, e.Y);
                    ProcessMenustrp.Show(dv,p);
                }
            }
        }

        private void DataGridView1_MouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)//判读是否是鼠标右键
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
                ProcessMenustrp.Show(MousePosition.X, MousePosition.Y);//contextMenuStrip1为菜单控件
            }
        }
        private void startOpenVpnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rgwr = dataGridView1.SelectedRows;
            if (rgwr[0] != null&&rgwr[0].Index!=-1)
            {
                openVpn.Startvpn(rgwr[0].Cells["OpenVPN_ConfigData_Base64"].Value.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ProcessMenustrp_Opening(object sender, CancelEventArgs e)
        {

        }

        private void VPNsetting_Click(object sender, EventArgs e)
        {
            VPNsetting VSF = new VPNsetting(this.openVpn);
            VSF.ShowDialog();
        }
    }
}