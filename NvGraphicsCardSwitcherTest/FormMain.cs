using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using NvGraphicsCardSwitcher;

namespace NvGraphicsCardSwitcherTest
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            string display;
            int result = NVidia.IsNVDisplay(out display);
            Console.WriteLine("IsNVDisplay = " + display + ", result = " + result.ToString());

            int select = NVidia.GetNVIDIA();
            Console.WriteLine("NV select = " + select.ToString());

            int connect = NVidia.GetConnectorInfo();
            Console.WriteLine("NV connect = " + connect.ToString());

            using (var searcher = new ManagementObjectSearcher("select * from Win32_VideoController"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("Name  -  " + obj["Name"]);
                    Console.WriteLine("DeviceID  -  " + obj["DeviceID"]);
                    Console.WriteLine("AdapterRAM  -  " + obj["AdapterRAM"]);
                    Console.WriteLine("AdapterDACType  -  " + obj["AdapterDACType"]);
                    Console.WriteLine("Monochrome  -  " + obj["Monochrome"]);
                    Console.WriteLine("InstalledDisplayDrivers  -  " + obj["InstalledDisplayDrivers"]);
                    Console.WriteLine("DriverVersion  -  " + obj["DriverVersion"]);
                    Console.WriteLine("VideoProcessor  -  " + obj["VideoProcessor"]);
                    Console.WriteLine("VideoArchitecture  -  " + obj["VideoArchitecture"]);
                    Console.WriteLine("VideoMemoryType  -  " + obj["VideoMemoryType"] );
                }
            }
        }

        private void btnChangeNV_Click(object sender, EventArgs e)
        {
            try
            {
                int connect = NVidia.GetConnectorInfo();

                Console.WriteLine("NV connect = " + connect.ToString());
            
                //
                // 0 - high performance
                // 1 - integrated
                // 2 - auto select
                //
                int select = NVidia.GetNVIDIA();
                Console.WriteLine("NV select = " + select.ToString());

                NvApi.Initialize();
                NVidia.SetNVHighPerformance();
                Console.WriteLine("Set NVHighPerformance Graphics!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnChangeIntel_Click(object sender, EventArgs e)
        {
            try
            {
                int connect = NVidia.GetConnectorInfo();

                Console.WriteLine("NV connect = " + connect.ToString());

                //
                // 0 - high performance
                // 1 - integrated
                // 2 - auto select
                //
                int select = NVidia.GetNVIDIA();
                Console.WriteLine("NV select = " + select.ToString());

                NvApi.Initialize();
                NVidia.SetIntegratedGraphics();
                Console.WriteLine("Set Integrated Graphics!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnChangeAuto_Click(object sender, EventArgs e)
        {
            try
            {
                int connect = NVidia.GetConnectorInfo();

                Console.WriteLine("NV connect = " + connect.ToString());

                //
                // 0 - high performance
                // 1 - integrated
                // 2 - auto select
                //
                int select = NVidia.GetNVIDIA();
                Console.WriteLine("NV select = " + select.ToString());

                NvApi.Initialize();
                NVidia.SetAutoSelectGraphics();
                Console.WriteLine("Set AutoSelect Graphics!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } 
    }
}
