using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChooseVPN
{
    public class VPNdataClass
    {
        private readonly WebClient _downloadCsvClient;
        public WebProxy Proxy;
        public bool ProxyFlag;
        private readonly string _url;
        private DataColumn _localPingcColumn;

        public VPNdataClass(bool flag, string IPadress, int port)
        {
            
            _downloadCsvClient = new WebClient();
            _url = "http://www.vpngate.net/api/iphone/";
            Proxy = SetPorxy(IPadress, port, flag);
            //DownloadCsv();
            Vpndata = new DataTable("VPNgate");
            //ReadCsv();
            //new Thread(LocalPing).Start();
        }

        public DataTable Vpndata { get; private set; }

        public void DownloadCsv()
        {
            if (ProxyFlag == false)
            {
                _downloadCsvClient.Proxy = null;
            }
            if (ProxyFlag == true)
            {
                _downloadCsvClient.Proxy = Proxy;
            }
            try
            {
                _downloadCsvClient.DownloadFile(_url, "vpndata.csv");
                var lines = new List<string>(File.ReadAllLines("vpndata.csv"));
                lines.RemoveAt(0);
                File.WriteAllLines("vpndata.csv", lines.ToArray());
            }
            catch (Exception)
            {
                MessageBox.Show("please cheak your net", "error");
            }         
        }

        public WebProxy SetPorxy(string IPadress, int post,bool flag)
        {
            ProxyFlag = flag;
            return new WebProxy("http://" + IPadress + ":" + post);
        }

        public void LocalPing()
        {
            //init a Ping sender
            var pingSender = new Ping();
            IPAddress address;
            PingReply reply;
            //Ping IP
            for (var count = 0; count < Vpndata.Rows.Count - 1; ++count)
            {
                var row = Vpndata.Rows[count];
                if(row["IP"]==null) continue;
                try
                {
                    address = IPAddress.Parse((string) row["IP"]);
                    reply = pingSender.Send(address);
                    long averageOfReplyTime = 0;
                    new Thread(() =>
                    {
                        var i = 0;
                        var j = 0;
                        for (; i < 4; ++i)
                        {
                            if (reply.Status == IPStatus.Success)
                            {
                                averageOfReplyTime += reply.RoundtripTime;
                                ++j;
                            }
                            else
                            {
                                Console.WriteLine(reply.Status);
                            }
                        }
                        row["LocalPing"] = j == 0 ? "no access" : (averageOfReplyTime/j).ToString();
                    }).Start();
                    Thread.Sleep(50);
                }
                catch (Exception e)
                {
                    
                }
            }
        }

        public void insertLocalPing()
        {
            _localPingcColumn = new DataColumn("LocalPing", typeof (string));
            Vpndata.Columns.Add(_localPingcColumn);
        }

        public void clearLocalPing()
        {
            for (int i = 0; i < Vpndata.Rows.Count - 1; ++i)
            {
                Vpndata.Rows[i]["LocalPing"] = null;
            }
        }

        public void ReadCsv()
        {
            
            Vpndata = new DataTable();
            clearLocalPing();
            string[] split = null;
            DataRow row = null;
            try
            {
                var sr = new StreamReader("vpndata.csv", Encoding.Default);
                //创建与数据源对应的数据列
                var line = sr.ReadLine();
                split = line.Split(',');
                foreach (var colname in split)
                {
                    Vpndata.Columns.Add(colname, Type.GetType("System.String"));
                }
                //将数据填入数据表
                var j = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    j = 0;
                    row = Vpndata.NewRow();
                    split = line.Split(',');
                    foreach (var colname in split)
                    {
                        row[j] = colname;
                        j++;
                    }
                    Vpndata.Rows.Add(row);
                }
                sr.Close();
                insertLocalPing();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Update data", "error!");
            }
            GC.Collect();
            
        }
    }
}