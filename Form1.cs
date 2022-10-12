using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace AutoCampusNetwork
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        public static extern int MessageBoxTimeoutA(IntPtr hWnd, string msg, string Caps, int type, int Id, int time);

        public Form1() //主入口
        {
            InitializeComponent();

            ReadSoftwareConfig();

            if (MyApps.Default.autolink && !CheckForInternetConnection())
            {
                Autologin();
            }

            tuopan.Visible = true;

            Label_Version.Text = "当前版本:v" + Application.ProductVersion;

            string appName = Process.GetCurrentProcess().MainModule.ModuleName;
            this.checkBox1.Checked = IsExistKey(appName);

            if (MyApps.Default.istoupan)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        public string Houzui()
        {
            if (comboBox1.Text == "抚州移动")
            {
                return "@fzcmcc";
            }
            else
            {
                if (comboBox1.Text == "抚州联通")
                {
                    return "@fzunicom";
                }
                else
                {
                    if (comboBox1.Text == "抚州电信")
                    {
                        return "@fztelecom";
                    }
                    else
                    {
                        return "";
                    }
                }
            }
        }

        public void Autologin()
        {
            long callback = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000;
            string useraccount = user_account.Text;
            string useuserpassword = user_password.Text;
            string login = "http://172.30.255.105:801/eportal/?c=Portal&a=login&callback=dr" + callback + "&login_method=1&user_account=" + useraccount + Houzui() + "&user_password=" + useuserpassword;
            MessageBoxTimeoutA((IntPtr)0, GetResponseString(CreateGetHttpResponse(login)), "", 0, 0, 3000);
        }

        public bool CheckForInternetConnection()
        {
            bool result = false;
            try
            {
                Ping ping = new Ping();
                PingReply replay = ping.Send("114.114.114.114", 2000);
                if (replay.Status == IPStatus.Success)
                {
                    result = true;
                }
            }
            catch { }
            return result;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_APPWINDOW = 0x40000;
                const int WS_EX_TOOLWINDOW = 0x80;
                CreateParams cp = base.CreateParams;
                cp.ExStyle &= (~WS_EX_APPWINDOW);
                cp.ExStyle |= WS_EX_TOOLWINDOW;
                return cp;
            }
        }

        private void ReadSoftwareConfig()
        {
            user_account.Text = MyApps.Default.user_account;
            user_password.Text = MyApps.Default.user_password;
            comboBox1.Text = MyApps.Default.isp;
            this.checkBox2.Checked = MyApps.Default.istoupan;
            this.checkBox3.Checked = MyApps.Default.autolink;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long callback = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000;
            string useraccount = user_account.Text;
            string useuserpassword = user_password.Text;
            string login = "http://172.30.255.105:801/eportal/?c=Portal&a=login&callback=dr" + callback + "&login_method=1&user_account=" + useraccount + Houzui() + "&user_password=" + useuserpassword;
            string output = login + "\n" + GetResponseString(CreateGetHttpResponse(login));
            MessageBox.Show(output);
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            string appName = Process.GetCurrentProcess().MainModule.ModuleName;
            bool Asdf = !IsExistKey(appName);
            SetMeStart(Asdf);
        }

        private void user_account_TextChanged(object sender, EventArgs e)
        {
            MyApps.Default.user_account = user_account.Text;
            MyApps.Default.Save();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            MyApps.Default.autolink = this.checkBox3.Checked;
            MyApps.Default.Save();
        }

        private void user_password_TextChanged(object sender, EventArgs e)
        {
            MyApps.Default.user_password = user_password.Text;
            MyApps.Default.Save();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            MyApps.Default.isp = comboBox1.Text;
            MyApps.Default.Save();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MyApps.Default.istoupan = this.checkBox2.Checked;
            MyApps.Default.Save();
        }

        public static HttpWebResponse CreateGetHttpResponse(string url)

        {

            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;

            request.Method = "GET";

            request.ContentType = "application/x-www-form-urlencoded";

            return request.GetResponse() as HttpWebResponse;

        }

        public string GetResponseString(HttpWebResponse webresponse)

        {

            using (Stream s = webresponse.GetResponseStream())

            {

                StreamReader reader = new StreamReader(s, Encoding.UTF8);

                return reader.ReadToEnd();

            }

        }

        public static bool SetMeStart(bool onOff)
        {
            bool isOk = false;
            string appName = Process.GetCurrentProcess().MainModule.ModuleName;
            string appPath = Process.GetCurrentProcess().MainModule.FileName;
            isOk = SetAutoStart(onOff, appName, appPath);
            return isOk;
        }

        public static bool SetAutoStart(bool onOff, string appName, string appPath)
        {
            bool isOk = true;
            if (!IsExistKey(appName) && onOff)
            {
                isOk = SelfRunning(onOff, appName, @appPath);
            }
            else if (IsExistKey(appName) && !onOff)
            {
                isOk = SelfRunning(onOff, appName, @appPath);
            }
            return isOk;
        }

        private static bool IsExistKey(string keyName)
        {
            try
            {
                bool _exist = false;
                RegistryKey local = Registry.LocalMachine;
                RegistryKey runs = local.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                if (runs == null)
                {
                    RegistryKey key2 = local.CreateSubKey("SOFTWARE");
                    RegistryKey key3 = key2.CreateSubKey("Microsoft");
                    RegistryKey key4 = key3.CreateSubKey("Windows");
                    RegistryKey key5 = key4.CreateSubKey("CurrentVersion");
                    RegistryKey key6 = key5.CreateSubKey("Run");
                    runs = key6;
                }
                string[] runsName = runs.GetValueNames();
                foreach (string strName in runsName)
                {
                    if (strName.ToUpper() == keyName.ToUpper())
                    {
                        _exist = true;
                        return _exist;
                    }
                }
                return _exist;

            }
            catch
            {
                return false;
            }
        }

        private static bool SelfRunning(bool isStart, string exeName, string path)
        {
            try
            {
                RegistryKey local = Registry.LocalMachine;
                RegistryKey key = local.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                if (key == null)
                {
                    local.CreateSubKey("SOFTWARE//Microsoft//Windows//CurrentVersion//Run");
                }
                if (isStart)
                {
                    key.SetValue(exeName, path);
                    key.Close();
                }
                else
                {
                    string[] keyNames = key.GetValueNames();
                    foreach (string keyName in keyNames)
                    {
                        if (keyName.ToUpper() == exeName.ToUpper())
                        {
                            key.DeleteValue(exeName);
                            key.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string ss = ex.Message;
                return false;
            }

            return true;
        }

        private void 显示主窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void 关闭schoollinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void 隐藏主窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/xinyihl");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/xinyihl/AutoCampusNetwork");
        }
    }
}

