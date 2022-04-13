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

        private void CheckADB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c adb shell getprop ro.product.model";
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();

            string outstr = p.StandardOutput.ReadToEnd();
            if (outstr == ""){
                MessageBox.Show("无设备连接");
            }
            else
            {
                MessageBox.Show("设备型号: "+outstr);
            }
            p.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c adb shell am startservice -n com.android.launcher3/com.drupe.swd.launcher.huoshan.mdm.service.ExecuteCmdService --es \"cmd\" \"command_bluetooth\" --ei \"active\" 1";
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();

            string outstr = p.StandardOutput.ReadToEnd();
            MessageBox.Show(outstr);
            p.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c adb shell am startservice -n com.android.launcher3/com.drupe.swd.launcher.huoshan.mdm.service.ExecuteCmdService --es \"cmd\" \"command_bluetooth\" --ei \"active\" 0";
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();

            string outstr = p.StandardOutput.ReadToEnd();
            MessageBox.Show(outstr);
            p.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c adb shell am startservice -n com.android.launcher3/com.drupe.swd.launcher.huoshan.mdm.service.ExecuteCmdService --es \"cmd\" \"command_sdcard_and_otg\" --ei \"active\" 1";
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();

            string outstr = p.StandardOutput.ReadToEnd();
            MessageBox.Show(outstr);
            p.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c adb shell am startservice -n com.android.launcher3/com.drupe.swd.launcher.huoshan.mdm.service.ExecuteCmdService --es \"cmd\" \"command_sdcard_and_otg\" --ei \"active\" 0";
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();

            string outstr = p.StandardOutput.ReadToEnd();
            MessageBox.Show(outstr);
            p.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c adb shell am startservice -n com.android.launcher3/com.drupe.swd.launcher.huoshan.mdm.service.ExecuteCmdService --es \"cmd\" \"command_reset_factory\"";
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();

            string outstr = p.StandardOutput.ReadToEnd();
            MessageBox.Show(outstr);
            p.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c adb shell am startservice -n com.android.launcher3/com.drupe.swd.launcher.huoshan.mdm.service.ExecuteCmdService --es \"cmd\" \"command_release_control\"";
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();

            string outstr = p.StandardOutput.ReadToEnd();
            MessageBox.Show(outstr);
            p.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.rebootdevice\"";
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();

            string outstr = p.StandardOutput.ReadToEnd();
            MessageBox.Show(outstr);
            p.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.shutdown\"";
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();

            string outstr = p.StandardOutput.ReadToEnd();
            MessageBox.Show(outstr);
            p.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.enablefirewall\"";
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();

            string outstr = p.StandardOutput.ReadToEnd();
            MessageBox.Show(outstr);
            p.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.disablefirewall\"";
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();

            string outstr = p.StandardOutput.ReadToEnd();
            MessageBox.Show(outstr);
            p.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.class.begin\"";
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();

            string outstr = p.StandardOutput.ReadToEnd();
            MessageBox.Show(outstr);
            p.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.class.over\"";
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();

            string outstr = p.StandardOutput.ReadToEnd();
            MessageBox.Show(outstr);
            p.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.disableapp\" --esal \"appwhitelist\" " + textBox1.Text;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();

            string outstr = p.StandardOutput.ReadToEnd();
            MessageBox.Show(outstr);
            p.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.setappwhitelist\" --esal \"appwhitelist\" " +textBox1.Text;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();

            string outstr = p.StandardOutput.ReadToEnd();
            MessageBox.Show(outstr);
            p.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.enableapp\" --esal \"appwhitelist\" " + textBox1.Text;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();

            string outstr = p.StandardOutput.ReadToEnd();
            MessageBox.Show(outstr);
            p.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.silentuninstall\" --es \"packageName\" " + textBox1.Text;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();

            string outstr = p.StandardOutput.ReadToEnd();
            MessageBox.Show(outstr);
            p.Close();
        }
    }
}
