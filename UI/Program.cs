using System;
using System.Windows.Forms;

namespace UI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          new FormLogin().Show();   //注释：制作时跳过登陆
          //  new MainForm("SuperAdmin").Show();
            Application.Run();
        }
    }
}
