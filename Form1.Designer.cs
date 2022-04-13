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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckADB
            // 
            this.CheckADB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CheckADB.Location = new System.Drawing.Point(6, 15);
            this.CheckADB.Name = "CheckADB";
            this.CheckADB.Size = new System.Drawing.Size(119, 42);
            this.CheckADB.TabIndex = 0;
            this.CheckADB.Text = "查看ADB连接";
            this.CheckADB.UseVisualStyleBackColor = true;
            this.CheckADB.Click += new System.EventHandler(this.CheckADB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(6, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "开蓝牙";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "关蓝牙";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(291, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "开sd卡&otg";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(433, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 38);
            this.button4.TabIndex = 2;
            this.button4.Text = "关sd卡&otg";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Location = new System.Drawing.Point(6, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 70);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设备";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(291, 24);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 38);
            this.button6.TabIndex = 2;
            this.button6.Text = "重启(调用领创)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(149, 24);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 38);
            this.button7.TabIndex = 1;
            this.button7.Text = "解控";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 24);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(136, 38);
            this.button8.TabIndex = 0;
            this.button8.Text = "恢复出厂";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.CheckADB);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 405);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(6, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 396);
            this.panel2.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(433, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 38);
            this.button5.TabIndex = 3;
            this.button5.Text = "关机(调用领创)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Location = new System.Drawing.Point(6, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(576, 70);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "其他";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(433, 24);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(136, 38);
            this.button9.TabIndex = 3;
            this.button9.Text = "下课";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(291, 24);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(136, 38);
            this.button10.TabIndex = 2;
            this.button10.Text = "上课";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(149, 24);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(136, 38);
            this.button11.TabIndex = 1;
            this.button11.Text = "关闭网络防火墙";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(6, 24);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(136, 38);
            this.button12.TabIndex = 0;
            this.button12.Text = "打开网络防火墙";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.button13);
            this.groupBox4.Controls.Add(this.button14);
            this.groupBox4.Controls.Add(this.button15);
            this.groupBox4.Controls.Add(this.button16);
            this.groupBox4.Location = new System.Drawing.Point(6, 288);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(576, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "APP";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(433, 50);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(136, 38);
            this.button13.TabIndex = 3;
            this.button13.Text = "写白名单";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(291, 50);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(136, 38);
            this.button14.TabIndex = 2;
            this.button14.Text = "卸载";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(149, 50);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(136, 38);
            this.button15.TabIndex = 1;
            this.button15.Text = "解冻";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(6, 50);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(136, 38);
            this.button16.TabIndex = 0;
            this.button16.Text = "冻结";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(562, 25);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(641, 397);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "abd toolbox ui";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CheckADB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
    }
}

