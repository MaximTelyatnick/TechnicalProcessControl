using Ninject;
using System;
using System.Windows.Forms;
using TerminalMKTelegramBot.Infrastructure;

namespace TechnicalProcessControl
{
    static class Program
    {
        public static IKernel kernel = new StandardKernel(new ServiceModule());
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainMenuFm());
            Application.Run(new LoginFm());
        }
    }
}
