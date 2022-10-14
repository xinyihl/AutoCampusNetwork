using System;
using System.Windows.Forms;

namespace AutoCampusNetwork
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] Args)
        {
            bool runone;
            System.Security.Principal.WindowsIdentity identity = System.Security.Principal.WindowsIdentity.GetCurrent();
            System.Security.Principal.WindowsPrincipal principal = new System.Security.Principal.WindowsPrincipal(identity);
            System.Threading.Mutex run = new System.Threading.Mutex(true, "single_test", out runone);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (runone)
            {
                if (MyApps.Default.autolink)
                {
                    Application.Run(new Form1());
                    run.ReleaseMutex();
                }
                else
                {
                    if (principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator))
                    {
                        Application.Run(new Form1());
                        run.ReleaseMutex();
                    }
                    else
                    {
                        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                        startInfo.UseShellExecute = true;
                        startInfo.WorkingDirectory = Environment.CurrentDirectory;
                        startInfo.FileName = Application.ExecutablePath;
                        startInfo.Verb = "runas";
                        try
                        {
                            System.Diagnostics.Process.Start(startInfo);
                        }
                        catch
                        {
                            return;
                        }
                        Application.Exit();
                    }
                }
            }
            else
            {
                MessageBox.Show("已经有一个程序已经在运行，请不要同时运行多个程序！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
