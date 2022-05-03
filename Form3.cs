using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abdUI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public String RunCommand(String Command)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c " + Command;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();

            string outstr = p.StandardOutput.ReadToEnd();
            p.Close();
            return outstr;
        }
            private void Install_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();       //获得路径
            Install(path);
        }

        private void Install_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;                                                              //重要代码：表明是所有类型的数据，比如文件路径
            else
                e.Effect = DragDropEffects.None;
        }
        private void Install(String path)
        {
            String PackageName = ApkInfo.PackageReader.GetPackageNameFromApk(FileToStream(path));
            if (textBox1.Text == string.Empty)
            {
                textBox1.Text =  "写入白名单 " + PackageName;
            }
            else
            {
                textBox1.Text = textBox1.Text + System.Environment.NewLine + "写入白名单 " + PackageName;
            }
            
            RunCommand("adb shell am broadcast -n com.android.launcher3/com.innofidei.guardsecure.service.EduAppReceiver -a \"com.linspirer.edu.setappwhitelist\" --esal \"appwhitelist\" " + PackageName);
            textBox1.Text = textBox1.Text + System.Environment.NewLine + "安装 " + path;
            MessageBox.Show(RunCommand("adb install \"" + path+"\""));
        }
        private string SelectFile()
        {
            string path = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Android 应用 (*.apk)|*.apk"//如果需要筛选txt文件（"Files (*.txt)|*.txt"）
            };

            //var result = openFileDialog.ShowDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openFileDialog.FileName;
            }

            return path;
        }

        public static Stream FileToStream(string filePath)
        {
            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read); //打开文件

            // 读取文件Byte[]
            //
            byte[] bytes = new byte[fileStream.Length];
            fileStream.Read(bytes, 0, bytes.Length);
            fileStream.Close();

            Stream stream = new MemoryStream(bytes); //byte[]转换为Stream
            return stream;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String path = SelectFile();
            if (path == string.Empty)
            {

            }
            else
            {
                Install(path);
            }
        }
    }
}
