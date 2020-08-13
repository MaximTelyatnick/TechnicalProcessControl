using System;
using System.IO;

namespace TechnicalProcessControl.BLL.Infrastructure
{
    public class Utils
    {

        public static string HomePath = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);

        public enum Operation
        {
            Add,
            Update,
            Template,
            Custom
        };

        public enum Rules
        {
            NoAuthUser,
            AuthUser,
            Manager,
            Admin
        };
    }
}
