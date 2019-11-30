using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalMKBot
{
    public class Utils
    {

        public enum Rules
        {
            NoAuthUser,
            AuthUser,
            Manager,
            Admin
        };

        public enum Operation
        {
            Add,
            Update,
            Template,
            Custom
        };


        public static string ConvertUTF8to1251(string strutf8)
        {
            Encoding utf8 = Encoding.GetEncoding("UTF-8");
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");

            byte[] utf8Bytes = win1251.GetBytes(strutf8);
            byte[] win1251Bytes = Encoding.Convert(utf8, win1251, utf8Bytes);

            string outputString = win1251.GetString(win1251Bytes);

            return outputString;
        }

        public static string Convert1251toUTF8(string str1251)
        {
            Encoding utf8 = Encoding.GetEncoding("UTF-8");
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");
            byte[] win1251Bytes = utf8.GetBytes(str1251);

            byte[] utf8Bytes = Encoding.Convert(win1251, utf8, win1251Bytes); ;


            string outputString = utf8.GetString(utf8Bytes);

            return outputString;
        }


    }
}
