using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abdUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public String AdbCommand(String Command)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c "+Command;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();

            string outstr = p.StandardOutput.ReadToEnd();
            p.Close();
            return outstr;
            
        }
        private void CheckADB_Click(object sender, EventArgs e)
        {
            string outstr = AdbCommand("adb shell getprop ro.product.model");
            if (outstr == ""){
                MessageBox.Show("无设备连接","警告");
            }
            else
            {
                MessageBox.Show("设备型号: "+outstr);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AdbCommand("adb shell am startservice -n com.android.launcher3/com.drupe.swd.launcher.huoshan.mdm.service.ExecuteCmdService --es \"cmd\" \"command_bluetooth\" --ei \"active\" 1"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AdbCommand("adb shell am startservice -n com.android.launcher3/com.drupe.swd.launcher.huoshan.mdm.service.ExecuteCmdService --es \"cmd\" \"command_bluetooth\" --ei \"active\" 0"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AdbCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.enableotg\""));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AdbCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.disableotg\""));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AdbCommand("adb shell am startservice -n com.android.launcher3/com.drupe.swd.launcher.huoshan.mdm.service.ExecuteCmdService --es \"cmd\" \"command_reset_factory\""));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AdbCommand("adb shell am startservice -n com.android.launcher3/com.drupe.swd.launcher.huoshan.mdm.service.ExecuteCmdService --es \"cmd\" \"command_release_control\""));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AdbCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.rebootdevice\""));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AdbCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.shutdown\""));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AdbCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.enablefirewall\""));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AdbCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.disablefirewall\""));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AdbCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.class.begin\""));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AdbCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.class.over\""));
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AdbCommand("adb shell am broadcast - n com.android.launcher3 / com.innofidei.guardsecure.service.EduAppReceiver - a \"com.linspirer.edu.disableapp\" --esal \"appwhitelist\" " + textBox1.Text));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AdbCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.setappwhitelist\" --esal \"appwhitelist\" " + textBox1.Text));
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AdbCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.enableapp\" --esal \"appwhitelist\" " + textBox1.Text));
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AdbCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.silentuninstall\" --es \"packageName\" " + textBox1.Text));
        }
    }
}
