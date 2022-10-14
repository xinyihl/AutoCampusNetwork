namespace AutoCampusNetwork
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TabControl_Main = new System.Windows.Forms.TabControl();
            this.TabPage_Main = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.user_password = new System.Windows.Forms.TextBox();
            this.user_account = new System.Windows.Forms.TextBox();
            this.TabPage_setings = new System.Windows.Forms.TabPage();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TabPage_About = new System.Windows.Forms.TabPage();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Label_Version = new System.Windows.Forms.Label();
            this.tuopan = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示主窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏主窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭schoollinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl_Main.SuspendLayout();
            this.TabPage_Main.SuspendLayout();
            this.TabPage_setings.SuspendLayout();
            this.TabPage_About.SuspendLayout();
            this.NotMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl_Main
            // 
            this.TabControl_Main.Controls.Add(this.TabPage_Main);
            this.TabControl_Main.Controls.Add(this.TabPage_setings);
            this.TabControl_Main.Controls.Add(this.TabPage_About);
            this.TabControl_Main.Location = new System.Drawing.Point(12, 12);
            this.TabControl_Main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabControl_Main.Name = "TabControl_Main";
            this.TabControl_Main.SelectedIndex = 0;
            this.TabControl_Main.Size = new System.Drawing.Size(328, 366);
            this.TabControl_Main.TabIndex = 1;
            // 
            // TabPage_Main
            // 
            this.TabPage_Main.Controls.Add(this.label9);
            this.TabPage_Main.Controls.Add(this.label8);
            this.TabPage_Main.Controls.Add(this.label7);
            this.TabPage_Main.Controls.Add(this.comboBox1);
            this.TabPage_Main.Controls.Add(this.button1);
            this.TabPage_Main.Controls.Add(this.user_password);
            this.TabPage_Main.Controls.Add(this.user_account);
            this.TabPage_Main.Location = new System.Drawing.Point(4, 28);
            this.TabPage_Main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabPage_Main.Name = "TabPage_Main";
            this.TabPage_Main.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabPage_Main.Size = new System.Drawing.Size(320, 334);
            this.TabPage_Main.TabIndex = 0;
            this.TabPage_Main.Text = "主页";
            this.TabPage_Main.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "运营商";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "密码";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "账号";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "抚州移动",
            "抚州联通",
            "抚州电信",
            "校园网"});
            this.comboBox1.Location = new System.Drawing.Point(77, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 26);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "手动登入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // user_password
            // 
            this.user_password.Location = new System.Drawing.Point(77, 89);
            this.user_password.Name = "user_password";
            this.user_password.Size = new System.Drawing.Size(208, 28);
            this.user_password.TabIndex = 1;
            this.user_password.TextChanged += new System.EventHandler(this.user_password_TextChanged);
            // 
            // user_account
            // 
            this.user_account.Location = new System.Drawing.Point(77, 34);
            this.user_account.Name = "user_account";
            this.user_account.Size = new System.Drawing.Size(208, 28);
            this.user_account.TabIndex = 0;
            this.user_account.TextChanged += new System.EventHandler(this.user_account_TextChanged);
            // 
            // TabPage_setings
            // 
            this.TabPage_setings.Controls.Add(this.checkBox3);
            this.TabPage_setings.Controls.Add(this.label6);
            this.TabPage_setings.Controls.Add(this.label5);
            this.TabPage_setings.Controls.Add(this.checkBox2);
            this.TabPage_setings.Controls.Add(this.label3);
            this.TabPage_setings.Controls.Add(this.label2);
            this.TabPage_setings.Controls.Add(this.checkBox1);
            this.TabPage_setings.Location = new System.Drawing.Point(4, 28);
            this.TabPage_setings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabPage_setings.Name = "TabPage_setings";
            this.TabPage_setings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabPage_setings.Size = new System.Drawing.Size(320, 334);
            this.TabPage_setings.TabIndex = 1;
            this.TabPage_setings.Text = "设置";
            this.TabPage_setings.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(209, 87);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(22, 21);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "自动登入需要先手动登入一次";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "自动登入";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(209, 55);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(22, 21);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "自动隐藏到托盘";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "开机自启";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(209, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // TabPage_About
            // 
            this.TabPage_About.Controls.Add(this.linkLabel2);
            this.TabPage_About.Controls.Add(this.label10);
            this.TabPage_About.Controls.Add(this.linkLabel1);
            this.TabPage_About.Controls.Add(this.label1);
            this.TabPage_About.Controls.Add(this.label4);
            this.TabPage_About.Location = new System.Drawing.Point(4, 28);
            this.TabPage_About.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabPage_About.Name = "TabPage_About";
            this.TabPage_About.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabPage_About.Size = new System.Drawing.Size(320, 334);
            this.TabPage_About.TabIndex = 2;
            this.TabPage_About.Text = "关于软件";
            this.TabPage_About.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(96, 305);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(62, 18);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "github";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "开源地址：";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(234, 305);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(71, 18);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "xinyihl";
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "作者：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 90);
            this.label4.TabIndex = 1;
            this.label4.Text = "本软件目前为临时作品，\n其中代码，逻辑均未作任何优化，\n只做了基本功能。\n\n代码已开源写的烂能用就行";
            // 
            // Label_Version
            // 
            this.Label_Version.AutoSize = true;
            this.Label_Version.ForeColor = System.Drawing.Color.Gray;
            this.Label_Version.Location = new System.Drawing.Point(13, 380);
            this.Label_Version.Name = "Label_Version";
            this.Label_Version.Size = new System.Drawing.Size(170, 18);
            this.Label_Version.TabIndex = 3;
            this.Label_Version.Text = "当前版本:读取中...";
            // 
            // tuopan
            // 
            this.tuopan.ContextMenuStrip = this.NotMenuStrip;
            this.tuopan.Icon = ((System.Drawing.Icon)(resources.GetObject("tuopan.Icon")));
            this.tuopan.Visible = true;
            // 
            // NotMenuStrip
            // 
            this.NotMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.NotMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示主窗口ToolStripMenuItem,
            this.隐藏主窗口ToolStripMenuItem,
            this.关闭schoollinkToolStripMenuItem});
            this.NotMenuStrip.Name = "NotMenuStrip";
            this.NotMenuStrip.Size = new System.Drawing.Size(303, 94);
            // 
            // 显示主窗口ToolStripMenuItem
            // 
            this.显示主窗口ToolStripMenuItem.Name = "显示主窗口ToolStripMenuItem";
            this.显示主窗口ToolStripMenuItem.Size = new System.Drawing.Size(302, 30);
            this.显示主窗口ToolStripMenuItem.Text = "显示主窗口";
            this.显示主窗口ToolStripMenuItem.Click += new System.EventHandler(this.显示主窗口ToolStripMenuItem_Click);
            // 
            // 隐藏主窗口ToolStripMenuItem
            // 
            this.隐藏主窗口ToolStripMenuItem.Name = "隐藏主窗口ToolStripMenuItem";
            this.隐藏主窗口ToolStripMenuItem.Size = new System.Drawing.Size(302, 30);
            this.隐藏主窗口ToolStripMenuItem.Text = "隐藏主窗口";
            this.隐藏主窗口ToolStripMenuItem.Click += new System.EventHandler(this.隐藏主窗口ToolStripMenuItem_Click);
            // 
            // 关闭schoollinkToolStripMenuItem
            // 
            this.关闭schoollinkToolStripMenuItem.Name = "关闭schoollinkToolStripMenuItem";
            this.关闭schoollinkToolStripMenuItem.Size = new System.Drawing.Size(302, 30);
            this.关闭schoollinkToolStripMenuItem.Text = "关闭AutoCampusNetwork";
            this.关闭schoollinkToolStripMenuItem.Click += new System.EventHandler(this.关闭schoollinkToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(352, 410);
            this.Controls.Add(this.Label_Version);
            this.Controls.Add(this.TabControl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoCampusNetwork";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl_Main.ResumeLayout(false);
            this.TabPage_Main.ResumeLayout(false);
            this.TabPage_Main.PerformLayout();
            this.TabPage_setings.ResumeLayout(false);
            this.TabPage_setings.PerformLayout();
            this.TabPage_About.ResumeLayout(false);
            this.TabPage_About.PerformLayout();
            this.NotMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl_Main;
        private System.Windows.Forms.TabPage TabPage_Main;
        private System.Windows.Forms.TabPage TabPage_setings;
        private System.Windows.Forms.TabPage TabPage_About;
        private System.Windows.Forms.Label Label_Version;
        private System.Windows.Forms.TextBox user_password;
        private System.Windows.Forms.TextBox user_account;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon tuopan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ContextMenuStrip NotMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 显示主窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭schoollinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隐藏主窗口ToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label10;
    }
}

