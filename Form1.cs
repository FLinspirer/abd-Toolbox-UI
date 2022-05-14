using NPOI.POIFS.Crypt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        public String RunCommand(String Command)
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
            string outstr = RunCommand("adb shell getprop ro.product.model");
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
            MessageBox.Show(RunCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.enablefileshare\""));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RunCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.disablefileshare\""));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RunCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.enableotg\""));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RunCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.disableotg\""));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RunCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.enable.screenshot\""));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RunCommand("adb shell am startservice -n com.android.launcher3/com.drupe.swd.launcher.huoshan.mdm.service.ExecuteCmdService --es \"cmd\" \"command_release_control\""));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RunCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.rebootdevice\""));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RunCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.shutdown\""));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RunCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.enablefirewall\""));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RunCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.disablefirewall\""));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RunCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.class.begin\""));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RunCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.class.over\""));
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RunCommand("adb shell am broadcast - n com.android.launcher3 / com.innofidei.guardsecure.service.EduAppReceiver - a \"com.linspirer.edu.disableapp\" --esal \"appwhitelist\" " + PackageNameTextBox.Text));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RunCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.setappwhitelist\" --esal \"appwhitelist\" " + PackageNameTextBox.Text));
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RunCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.enableapp\" --esal \"appwhitelist\" " + PackageNameTextBox.Text));
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RunCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.silentuninstall\" --es \"packageName\" " + PackageNameTextBox.Text));
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RunCommand("adb shell pm disable-user com.android.launcher3"));
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RunCommand("adb shell pm enable com.android.launcher3"));
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RunCommand("adb shell pm clear com.android.launcher3"));
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RunCommand("adb shell su -c \"am start -n com.android.launcher3/com.innofidei.guardsecure.AdminActivity\""));
        }

        private void WipeData1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RunCommand("adb shell am broadcast -a android.intent.action.MASTER_CLEAR"));
        }

        private void WipeData2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RunCommand("adb shell am broadcast -a android.intent.action.MASTER_CLEAR -f 0x01000000"));
        }

        private void WipeData3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RunCommand("adb shell su -c \"am broadcast -a android.intent.action.MASTER_CLEAR\""));
        }

        private void WipeDatabyLinspirer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RunCommand("adb shell am startservice -n com.android.launcher3 / com.drupe.swd.launcher.huoshan.mdm.service.ExecuteCmdService--es \"cmd\" \"command_reset_factory\""));
        }

        private void ABOUT_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            String key500 = "1191ADF1-8489-D8DA-5E9B-755A8B674394-485SDEWQ-QWYHK586";
            String key501 = "40E06F51-30D0-D6AD-7F7D-008AD0ADC570";
            String swdid = textBox1.Text;
            string pass500 = calc(swdid, key500);
            string pass501 = calc(swdid, key501);
            textBox2.Text = "5.0.***:" + pass500 + System.Environment.NewLine + "5.01.***:" + pass501;
        }
        public static string calc(string str, string key)
        {
            string str2 = DateTime.Now.ToString("yyyyMMdd") + str + key;
            string b = m3759b(str2);
            if (b.Length > 8)
            {
                var tempVar = b.Length - 8;
                return m3758c(b.Substring(tempVar, b.Length - (tempVar)));
            }
            return "";
        }
        public static string m3759b(string str)
        {
                sbyte[] bytes = str.GetBytes();
                MessageDigest instance = MessageDigest.getInstance("md5");
                instance.reset();
                instance.update(bytes);
                sbyte[] digest = instance.digest();
                StringBuilder sb = new StringBuilder();
                foreach (sbyte b in digest)
                {
                    string hexString = (b & 255).ToString("x");
                    if (hexString.Length == 1)
                    {
                        hexString = "0" + hexString;
                    }
                    sb.Append(hexString);
                }
                return sb.ToString();
            
        }
        public static string m3758c(string str)
        {
            string valueOf = Convert.ToInt64(str, 16).ToString();
            if (valueOf.Length <= 8)
            {
                return valueOf;
            }
            var tempVar = valueOf.Length - 8;
            return valueOf.Substring(tempVar, valueOf.Length - (tempVar));
        }

        public static string GetMD5WithString(String str)
        {
            MD5 md5Hash = MD5.Create();
            // 将输入字符串转换为字节数组并计算哈希数据  
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(str));
            // 创建一个 Stringbuilder 来收集字节并创建字符串  
            StringBuilder strout = new StringBuilder();
            // 循环遍历哈希数据的每一个字节并格式化为十六进制字符串  
            for (int i = 0; i < data.Length; i++)
            {
                strout.Append(data[i].ToString("x2"));//加密结果"x2"结果为32位,"x3"结果为48位,"x4"结果为64位
            }
            // 返回十六进制字符串  
            return strout.ToString();
        }

    }
}
