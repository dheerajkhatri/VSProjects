using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace IPdriver
{
    public partial class f_ipdriver : Form
    {
        public f_ipdriver()
        {
            InitializeComponent();
        }

        public static void SetIP(string nicName, string IpAddresses,
            string SubnetMask, string Gateway, string DnsSearchOrder)
        {
            ManagementClass mc = new ManagementClass(
              "Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                // Make sure this is a IP enabled device. 

                // Not something like memory card or VM Ware

                if (mo["IPEnabled"] as bool)
                {
                    if (mo["Caption"].Equals(nicName))
                    {

                        ManagementBaseObject newIP =
                          mo.GetMethodParameters("EnableStatic");
                        ManagementBaseObject newGate =
                          mo.GetMethodParameters("SetGateways");
                        ManagementBaseObject newDNS =
                          mo.GetMethodParameters("SetDNSServerSearchOrder");

                        newGate["DefaultIPGateway"] = new string[] { Gateway };
                        newGate["GatewayCostMetric"] = new int[] { 1 };

                        newIP["IPAddress"] = IpAddresses.Split(',');
                        newIP["SubnetMask"] = new string[] { SubnetMask };

                        newDNS["DNSServerSearchOrder"] = DnsSearchOrder.Split(',');

                        ManagementBaseObject setIP = mo.InvokeMethod(
                          "EnableStatic", newIP, null);
                        ManagementBaseObject setGateways = mo.InvokeMethod(
                          "SetGateways", newGate, null);
                        ManagementBaseObject setDNS = mo.InvokeMethod(
                          "SetDNSServerSearchOrder", newDNS, null);

                        break;
                    }
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dropdown_adddata();
            String IPAddress = "10.4.2.19";
            String SubNetMask = "255.255.252.0";
            String DefaultGateway = "10.4.0.254";


            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            

        }


        private void dropdown_adddata()
        {

            TextReader tr = new StreamReader("F://workspace//VS2013 Projects//savedData.txt");

            String line;

            while ((line = tr.ReadLine()) != null)
            {
                //Console.WriteLine(line);
                //domainUpDown1.Items.Add(line);
                String[] data = line.Split(null);
                String IP, SM, DG;
                IP = data[0];
                SM = data[1];
                DG = data[2];
                Console.WriteLine(IP);
                Console.WriteLine(SM);
                Console.WriteLine(DG);

                domainUpDown1.Items.Add(IP + "-" + SM + "-" + DG);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            f_newip newform = new f_newip();
            newform.Show();            
        }

        private void f_ipdriver_Load(object sender, EventArgs e)
        {

        }
    }
}
