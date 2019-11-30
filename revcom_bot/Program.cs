using Ninject;
using TerminalMKTelegramBot.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerminalMKTelegramBot
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
            //Application.Run(new Main());
            Application.Run(new Main());
        }
    }
}
