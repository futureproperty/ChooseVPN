using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseVPN
{
    public class OpenVpnClass
    {
        private Process OpenVpnExe;
        public string Filepath;

        public void Startvpn(string base64_config)
        {
            byte[] data = Convert.FromBase64String(base64_config);
            string  paracontent= Encoding.UTF8.GetString(data);
            File.WriteAllText("vpnfile",paracontent);
            //filepath = @"D:\Program Files (x86)\OpenVPN\bin\openvpn.exe";
            OpenVpnExe =new Process();
            ProcessStartInfo OpenVpnExeInfo=new ProcessStartInfo(Filepath, "vpnfile");
            OpenVpnExe.StartInfo = OpenVpnExeInfo; 
            OpenVpnExe.Start();
        }
    }
}
