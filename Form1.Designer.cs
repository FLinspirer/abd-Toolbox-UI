namespace abdUI
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CheckADB = new System.Windows.Forms.Button();
            this.ConnectionsGroupBox = new System.Windows.Forms.GroupBox();
            this.DisableOTG = new System.Windows.Forms.Button();
            this.EnableOTG = new System.Windows.Forms.Button();
            this.DisableFileShare = new System.Windows.Forms.Button();
            this.EnableFileShare = new System.Windows.Forms.Button();
            this.DeviceGroupBox = new System.Windows.Forms.GroupBox();
            this.Poweroff = new System.Windows.Forms.Button();
            this.Reboot = new System.Windows.Forms.Button();
            this.ReleaseControl = new System.Windows.Forms.Button();
            this.EnableScreenshot = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ABOUT = new System.Windows.Forms.Button();
            this.DataGroupBox = new System.Windows.Forms.GroupBox();
            this.WipeDatabyLinspirer = new System.Windows.Forms.Button();
            this.WipeData3 = new System.Windows.Forms.Button();
            this.WipeData2 = new System.Windows.Forms.Button();
            this.WipeData1 = new System.Windows.Forms.Button();
            this.LinspirerGroupBox = new System.Windows.Forms.GroupBox();
            this.OpenAdminSettings = new System.Windows.Forms.Button();
            this.ClearLinspirer = new System.Windows.Forms.Button();
            this.EnableLinspirer = new System.Windows.Forms.Button();
            this.DisableLinspirer = new System.Windows.Forms.Button();
            this.AppGroupBox = new System.Windows.Forms.GroupBox();
            this.PackageNameTextBox = new System.Windows.Forms.TextBox();
            this.AddAppWhiteList = new System.Windows.Forms.Button();
            this.SilentUninstallApp = new System.Windows.Forms.Button();
            this.EnableApp = new System.Windows.Forms.Button();
            this.DisableApp = new System.Windows.Forms.Button();
            this.OthersGroupBox = new System.Windows.Forms.GroupBox();
            this.ClassOver = new System.Windows.Forms.Button();
            this.ClassBegin = new System.Windows.Forms.Button();
            this.DisableFirewall = new System.Windows.Forms.Button();
            this.EnableFirewall = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.ConnectionsGroupBox.SuspendLayout();
            this.DeviceGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.DataGroupBox.SuspendLayout();
            this.LinspirerGroupBox.SuspendLayout();
            this.AppGroupBox.SuspendLayout();
            this.OthersGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckADB
            // 
            this.CheckADB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CheckADB.Location = new System.Drawing.Point(6, 15);
            this.CheckADB.Name = "CheckADB";
            this.CheckADB.Size = new System.Drawing.Size(136, 38);
            this.CheckADB.TabIndex = 0;
            this.CheckADB.Text = "查看ADB连接";
            this.CheckADB.UseVisualStyleBackColor = true;
            this.CheckADB.Click += new System.EventHandler(this.CheckADB_Click);
            // 
            // ConnectionsGroupBox
            // 
            this.ConnectionsGroupBox.Controls.Add(this.DisableOTG);
            this.ConnectionsGroupBox.Controls.Add(this.EnableOTG);
            this.ConnectionsGroupBox.Controls.Add(this.DisableFileShare);
            this.ConnectionsGroupBox.Controls.Add(this.EnableFileShare);
            this.ConnectionsGroupBox.Location = new System.Drawing.Point(6, 63);
            this.ConnectionsGroupBox.Name = "ConnectionsGroupBox";
            this.ConnectionsGroupBox.Size = new System.Drawing.Size(576, 70);
            this.ConnectionsGroupBox.TabIndex = 1;
            this.ConnectionsGroupBox.TabStop = false;
            this.ConnectionsGroupBox.Text = "连接";
            // 
            // DisableOTG
            // 
            this.DisableOTG.Location = new System.Drawing.Point(433, 24);
            this.DisableOTG.Name = "DisableOTG";
            this.DisableOTG.Size = new System.Drawing.Size(136, 38);
            this.DisableOTG.TabIndex = 2;
            this.DisableOTG.Text = "关otg";
            this.DisableOTG.UseVisualStyleBackColor = true;
            this.DisableOTG.Click += new System.EventHandler(this.button4_Click);
            // 
            // EnableOTG
            // 
            this.EnableOTG.Location = new System.Drawing.Point(291, 24);
            this.EnableOTG.Name = "EnableOTG";
            this.EnableOTG.Size = new System.Drawing.Size(136, 38);
            this.EnableOTG.TabIndex = 2;
            this.EnableOTG.Text = "开otg";
            this.EnableOTG.UseVisualStyleBackColor = true;
            this.EnableOTG.Click += new System.EventHandler(this.button3_Click);
            // 
            // DisableFileShare
            // 
            this.DisableFileShare.Location = new System.Drawing.Point(149, 24);
            this.DisableFileShare.Name = "DisableFileShare";
            this.DisableFileShare.Size = new System.Drawing.Size(136, 38);
            this.DisableFileShare.TabIndex = 1;
            this.DisableFileShare.Text = "关蓝牙";
            this.DisableFileShare.UseVisualStyleBackColor = true;
            this.DisableFileShare.Click += new System.EventHandler(this.button2_Click);
            // 
            // EnableFileShare
            // 
            this.EnableFileShare.Location = new System.Drawing.Point(6, 24);
            this.EnableFileShare.Name = "EnableFileShare";
            this.EnableFileShare.Size = new System.Drawing.Size(136, 38);
            this.EnableFileShare.TabIndex = 0;
            this.EnableFileShare.Text = "开蓝牙";
            this.EnableFileShare.UseVisualStyleBackColor = true;
            this.EnableFileShare.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeviceGroupBox
            // 
            this.DeviceGroupBox.Controls.Add(this.Poweroff);
            this.DeviceGroupBox.Controls.Add(this.Reboot);
            this.DeviceGroupBox.Controls.Add(this.ReleaseControl);
            this.DeviceGroupBox.Controls.Add(this.EnableScreenshot);
            this.DeviceGroupBox.Location = new System.Drawing.Point(6, 138);
            this.DeviceGroupBox.Name = "DeviceGroupBox";
            this.DeviceGroupBox.Size = new System.Drawing.Size(576, 70);
            this.DeviceGroupBox.TabIndex = 2;
            this.DeviceGroupBox.TabStop = false;
            this.DeviceGroupBox.Text = "设备";
            // 
            // Poweroff
            // 
            this.Poweroff.Location = new System.Drawing.Point(433, 24);
            this.Poweroff.Name = "Poweroff";
            this.Poweroff.Size = new System.Drawing.Size(136, 38);
            this.Poweroff.TabIndex = 3;
            this.Poweroff.Text = "关机(调用领创)";
            this.Poweroff.UseVisualStyleBackColor = true;
            this.Poweroff.Click += new System.EventHandler(this.button5_Click);
            // 
            // Reboot
            // 
            this.Reboot.Location = new System.Drawing.Point(291, 24);
            this.Reboot.Name = "Reboot";
            this.Reboot.Size = new System.Drawing.Size(136, 38);
            this.Reboot.TabIndex = 2;
            this.Reboot.Text = "重启(调用领创)";
            this.Reboot.UseVisualStyleBackColor = true;
            this.Reboot.Click += new System.EventHandler(this.button6_Click);
            // 
            // ReleaseControl
            // 
            this.ReleaseControl.Location = new System.Drawing.Point(149, 24);
            this.ReleaseControl.Name = "ReleaseControl";
            this.ReleaseControl.Size = new System.Drawing.Size(136, 38);
            this.ReleaseControl.TabIndex = 1;
            this.ReleaseControl.Text = "解控";
            this.ReleaseControl.UseVisualStyleBackColor = true;
            this.ReleaseControl.Click += new System.EventHandler(this.button7_Click);
            // 
            // EnableScreenshot
            // 
            this.EnableScreenshot.Location = new System.Drawing.Point(6, 24);
            this.EnableScreenshot.Name = "EnableScreenshot";
            this.EnableScreenshot.Size = new System.Drawing.Size(136, 38);
            this.EnableScreenshot.TabIndex = 0;
            this.EnableScreenshot.Text = "允许截图";
            this.EnableScreenshot.UseVisualStyleBackColor = true;
            this.EnableScreenshot.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ABOUT);
            this.panel1.Controls.Add(this.DataGroupBox);
            this.panel1.Controls.Add(this.LinspirerGroupBox);
            this.panel1.Controls.Add(this.AppGroupBox);
            this.panel1.Controls.Add(this.OthersGroupBox);
            this.panel1.Controls.Add(this.CheckADB);
            this.panel1.Controls.Add(this.DeviceGroupBox);
            this.panel1.Controls.Add(this.ConnectionsGroupBox);
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 707);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(3, 628);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "动态密码（因为Java和C#数组范围不一致用不了）";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(291, 24);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(277, 38);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 25);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "计算";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(297, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "安装APK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ABOUT
            // 
            this.ABOUT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ABOUT.Location = new System.Drawing.Point(439, 15);
            this.ABOUT.Name = "ABOUT";
            this.ABOUT.Size = new System.Drawing.Size(136, 38);
            this.ABOUT.TabIndex = 6;
            this.ABOUT.Text = "关于";
            this.ABOUT.UseVisualStyleBackColor = true;
            this.ABOUT.Click += new System.EventHandler(this.ABOUT_Click);
            // 
            // DataGroupBox
            // 
            this.DataGroupBox.Controls.Add(this.WipeDatabyLinspirer);
            this.DataGroupBox.Controls.Add(this.WipeData3);
            this.DataGroupBox.Controls.Add(this.WipeData2);
            this.DataGroupBox.Controls.Add(this.WipeData1);
            this.DataGroupBox.Location = new System.Drawing.Point(6, 320);
            this.DataGroupBox.Name = "DataGroupBox";
            this.DataGroupBox.Size = new System.Drawing.Size(576, 70);
            this.DataGroupBox.TabIndex = 5;
            this.DataGroupBox.TabStop = false;
            this.DataGroupBox.Text = "恢复出厂";
            // 
            // WipeDatabyLinspirer
            // 
            this.WipeDatabyLinspirer.Location = new System.Drawing.Point(433, 24);
            this.WipeDatabyLinspirer.Name = "WipeDatabyLinspirer";
            this.WipeDatabyLinspirer.Size = new System.Drawing.Size(136, 38);
            this.WipeDatabyLinspirer.TabIndex = 3;
            this.WipeDatabyLinspirer.Text = "调用领创";
            this.WipeDatabyLinspirer.UseVisualStyleBackColor = true;
            this.WipeDatabyLinspirer.Click += new System.EventHandler(this.WipeDatabyLinspirer_Click);
            // 
            // WipeData3
            // 
            this.WipeData3.Location = new System.Drawing.Point(291, 24);
            this.WipeData3.Name = "WipeData3";
            this.WipeData3.Size = new System.Drawing.Size(136, 38);
            this.WipeData3.TabIndex = 2;
            this.WipeData3.Text = "su";
            this.WipeData3.UseVisualStyleBackColor = true;
            this.WipeData3.Click += new System.EventHandler(this.WipeData3_Click);
            // 
            // WipeData2
            // 
            this.WipeData2.Location = new System.Drawing.Point(149, 24);
            this.WipeData2.Name = "WipeData2";
            this.WipeData2.Size = new System.Drawing.Size(136, 38);
            this.WipeData2.TabIndex = 1;
            this.WipeData2.Text = "Android 8.0+";
            this.WipeData2.UseVisualStyleBackColor = true;
            this.WipeData2.Click += new System.EventHandler(this.WipeData2_Click);
            // 
            // WipeData1
            // 
            this.WipeData1.Location = new System.Drawing.Point(6, 24);
            this.WipeData1.Name = "WipeData1";
            this.WipeData1.Size = new System.Drawing.Size(136, 38);
            this.WipeData1.TabIndex = 0;
            this.WipeData1.Text = "Android 7.1-";
            this.WipeData1.UseVisualStyleBackColor = true;
            this.WipeData1.Click += new System.EventHandler(this.WipeData1_Click);
            // 
            // LinspirerGroupBox
            // 
            this.LinspirerGroupBox.Controls.Add(this.OpenAdminSettings);
            this.LinspirerGroupBox.Controls.Add(this.ClearLinspirer);
            this.LinspirerGroupBox.Controls.Add(this.EnableLinspirer);
            this.LinspirerGroupBox.Controls.Add(this.DisableLinspirer);
            this.LinspirerGroupBox.Location = new System.Drawing.Point(6, 396);
            this.LinspirerGroupBox.Name = "LinspirerGroupBox";
            this.LinspirerGroupBox.Size = new System.Drawing.Size(576, 70);
            this.LinspirerGroupBox.TabIndex = 4;
            this.LinspirerGroupBox.TabStop = false;
            this.LinspirerGroupBox.Text = "领创";
            // 
            // OpenAdminSettings
            // 
            this.OpenAdminSettings.Location = new System.Drawing.Point(433, 24);
            this.OpenAdminSettings.Name = "OpenAdminSettings";
            this.OpenAdminSettings.Size = new System.Drawing.Size(136, 38);
            this.OpenAdminSettings.TabIndex = 3;
            this.OpenAdminSettings.Text = "强开管理员(su)";
            this.OpenAdminSettings.UseVisualStyleBackColor = true;
            this.OpenAdminSettings.Click += new System.EventHandler(this.button17_Click);
            // 
            // ClearLinspirer
            // 
            this.ClearLinspirer.Location = new System.Drawing.Point(291, 24);
            this.ClearLinspirer.Name = "ClearLinspirer";
            this.ClearLinspirer.Size = new System.Drawing.Size(136, 38);
            this.ClearLinspirer.TabIndex = 2;
            this.ClearLinspirer.Text = "清除数据";
            this.ClearLinspirer.UseVisualStyleBackColor = true;
            this.ClearLinspirer.Click += new System.EventHandler(this.button18_Click);
            // 
            // EnableLinspirer
            // 
            this.EnableLinspirer.Location = new System.Drawing.Point(149, 24);
            this.EnableLinspirer.Name = "EnableLinspirer";
            this.EnableLinspirer.Size = new System.Drawing.Size(136, 38);
            this.EnableLinspirer.TabIndex = 1;
            this.EnableLinspirer.Text = "解冻";
            this.EnableLinspirer.UseVisualStyleBackColor = true;
            this.EnableLinspirer.Click += new System.EventHandler(this.button19_Click);
            // 
            // DisableLinspirer
            // 
            this.DisableLinspirer.Location = new System.Drawing.Point(6, 24);
            this.DisableLinspirer.Name = "DisableLinspirer";
            this.DisableLinspirer.Size = new System.Drawing.Size(136, 38);
            this.DisableLinspirer.TabIndex = 0;
            this.DisableLinspirer.Text = "冻结";
            this.DisableLinspirer.UseVisualStyleBackColor = true;
            this.DisableLinspirer.Click += new System.EventHandler(this.button20_Click);
            // 
            // AppGroupBox
            // 
            this.AppGroupBox.Controls.Add(this.PackageNameTextBox);
            this.AppGroupBox.Controls.Add(this.AddAppWhiteList);
            this.AppGroupBox.Controls.Add(this.SilentUninstallApp);
            this.AppGroupBox.Controls.Add(this.EnableApp);
            this.AppGroupBox.Controls.Add(this.DisableApp);
            this.AppGroupBox.Location = new System.Drawing.Point(6, 214);
            this.AppGroupBox.Name = "AppGroupBox";
            this.AppGroupBox.Size = new System.Drawing.Size(576, 100);
            this.AppGroupBox.TabIndex = 4;
            this.AppGroupBox.TabStop = false;
            this.AppGroupBox.Text = "APP";
            // 
            // PackageNameTextBox
            // 
            this.PackageNameTextBox.Location = new System.Drawing.Point(6, 19);
            this.PackageNameTextBox.Name = "PackageNameTextBox";
            this.PackageNameTextBox.Size = new System.Drawing.Size(562, 25);
            this.PackageNameTextBox.TabIndex = 4;
            // 
            // AddAppWhiteList
            // 
            this.AddAppWhiteList.Location = new System.Drawing.Point(433, 50);
            this.AddAppWhiteList.Name = "AddAppWhiteList";
            this.AddAppWhiteList.Size = new System.Drawing.Size(136, 38);
            this.AddAppWhiteList.TabIndex = 3;
            this.AddAppWhiteList.Text = "写白名单";
            this.AddAppWhiteList.UseVisualStyleBackColor = true;
            this.AddAppWhiteList.Click += new System.EventHandler(this.button13_Click);
            // 
            // SilentUninstallApp
            // 
            this.SilentUninstallApp.Location = new System.Drawing.Point(291, 50);
            this.SilentUninstallApp.Name = "SilentUninstallApp";
            this.SilentUninstallApp.Size = new System.Drawing.Size(136, 38);
            this.SilentUninstallApp.TabIndex = 2;
            this.SilentUninstallApp.Text = "卸载";
            this.SilentUninstallApp.UseVisualStyleBackColor = true;
            this.SilentUninstallApp.Click += new System.EventHandler(this.button14_Click);
            // 
            // EnableApp
            // 
            this.EnableApp.Location = new System.Drawing.Point(149, 50);
            this.EnableApp.Name = "EnableApp";
            this.EnableApp.Size = new System.Drawing.Size(136, 38);
            this.EnableApp.TabIndex = 1;
            this.EnableApp.Text = "解冻";
            this.EnableApp.UseVisualStyleBackColor = true;
            this.EnableApp.Click += new System.EventHandler(this.button15_Click);
            // 
            // DisableApp
            // 
            this.DisableApp.Location = new System.Drawing.Point(6, 50);
            this.DisableApp.Name = "DisableApp";
            this.DisableApp.Size = new System.Drawing.Size(136, 38);
            this.DisableApp.TabIndex = 0;
            this.DisableApp.Text = "冻结";
            this.DisableApp.UseVisualStyleBackColor = true;
            this.DisableApp.Click += new System.EventHandler(this.button16_Click);
            // 
            // OthersGroupBox
            // 
            this.OthersGroupBox.Controls.Add(this.ClassOver);
            this.OthersGroupBox.Controls.Add(this.ClassBegin);
            this.OthersGroupBox.Controls.Add(this.DisableFirewall);
            this.OthersGroupBox.Controls.Add(this.EnableFirewall);
            this.OthersGroupBox.Location = new System.Drawing.Point(6, 471);
            this.OthersGroupBox.Name = "OthersGroupBox";
            this.OthersGroupBox.Size = new System.Drawing.Size(576, 70);
            this.OthersGroupBox.TabIndex = 3;
            this.OthersGroupBox.TabStop = false;
            this.OthersGroupBox.Text = "其他";
            // 
            // ClassOver
            // 
            this.ClassOver.Location = new System.Drawing.Point(433, 24);
            this.ClassOver.Name = "ClassOver";
            this.ClassOver.Size = new System.Drawing.Size(136, 38);
            this.ClassOver.TabIndex = 3;
            this.ClassOver.Text = "下课";
            this.ClassOver.UseVisualStyleBackColor = true;
            this.ClassOver.Click += new System.EventHandler(this.button9_Click);
            // 
            // ClassBegin
            // 
            this.ClassBegin.Location = new System.Drawing.Point(291, 24);
            this.ClassBegin.Name = "ClassBegin";
            this.ClassBegin.Size = new System.Drawing.Size(136, 38);
            this.ClassBegin.TabIndex = 2;
            this.ClassBegin.Text = "上课";
            this.ClassBegin.UseVisualStyleBackColor = true;
            this.ClassBegin.Click += new System.EventHandler(this.button10_Click);
            // 
            // DisableFirewall
            // 
            this.DisableFirewall.Location = new System.Drawing.Point(149, 24);
            this.DisableFirewall.Name = "DisableFirewall";
            this.DisableFirewall.Size = new System.Drawing.Size(136, 38);
            this.DisableFirewall.TabIndex = 1;
            this.DisableFirewall.Text = "关闭网络防火墙";
            this.DisableFirewall.UseVisualStyleBackColor = true;
            this.DisableFirewall.Click += new System.EventHandler(this.button11_Click);
            // 
            // EnableFirewall
            // 
            this.EnableFirewall.Location = new System.Drawing.Point(6, 24);
            this.EnableFirewall.Name = "EnableFirewall";
            this.EnableFirewall.Size = new System.Drawing.Size(136, 38);
            this.EnableFirewall.TabIndex = 0;
            this.EnableFirewall.Text = "打开网络防火墙";
            this.EnableFirewall.UseVisualStyleBackColor = true;
            this.EnableFirewall.Click += new System.EventHandler(this.button12_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Location = new System.Drawing.Point(6, 551);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 70);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tensafe";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(149, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 38);
            this.button5.TabIndex = 1;
            this.button5.Text = "DebugActivity";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 24);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 38);
            this.button6.TabIndex = 0;
            this.button6.Text = "EdXposed";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(646, 397);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "abd toolbox ui";
            this.ConnectionsGroupBox.ResumeLayout(false);
            this.DeviceGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DataGroupBox.ResumeLayout(false);
            this.LinspirerGroupBox.ResumeLayout(false);
            this.AppGroupBox.ResumeLayout(false);
            this.AppGroupBox.PerformLayout();
            this.OthersGroupBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CheckADB;
        private System.Windows.Forms.GroupBox ConnectionsGroupBox;
        private System.Windows.Forms.Button DisableOTG;
        private System.Windows.Forms.Button EnableOTG;
        private System.Windows.Forms.Button DisableFileShare;
        private System.Windows.Forms.Button EnableFileShare;
        private System.Windows.Forms.GroupBox DeviceGroupBox;
        private System.Windows.Forms.Button Reboot;
        private System.Windows.Forms.Button ReleaseControl;
        private System.Windows.Forms.Button EnableScreenshot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Poweroff;
        private System.Windows.Forms.GroupBox OthersGroupBox;
        private System.Windows.Forms.Button ClassOver;
        private System.Windows.Forms.Button ClassBegin;
        private System.Windows.Forms.Button DisableFirewall;
        private System.Windows.Forms.Button EnableFirewall;
        private System.Windows.Forms.GroupBox AppGroupBox;
        private System.Windows.Forms.TextBox PackageNameTextBox;
        private System.Windows.Forms.Button AddAppWhiteList;
        private System.Windows.Forms.Button SilentUninstallApp;
        private System.Windows.Forms.Button EnableApp;
        private System.Windows.Forms.Button DisableApp;
        private System.Windows.Forms.GroupBox LinspirerGroupBox;
        private System.Windows.Forms.Button OpenAdminSettings;
        private System.Windows.Forms.Button ClearLinspirer;
        private System.Windows.Forms.Button EnableLinspirer;
        private System.Windows.Forms.Button DisableLinspirer;
        private System.Windows.Forms.GroupBox DataGroupBox;
        private System.Windows.Forms.Button WipeDatabyLinspirer;
        private System.Windows.Forms.Button WipeData3;
        private System.Windows.Forms.Button WipeData2;
        private System.Windows.Forms.Button WipeData1;
        private System.Windows.Forms.Button ABOUT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

