﻿using System.IO;
using System.Text;
using System.Linq;
using System;

namespace TechnicalProcessControl
{
    public class Utils
    {
        public static string HomePath = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);

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

        public enum TechProcesFileMode
        {
            AddTechProcess,
            UpdateTechProcess,
            TemplateTechProcess
        };

        static string[] Article =
            {
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
                "n","o", "p","q","r","s","t","u","v","w","x","y","z"  
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




        public static bool DirectoryContainFiles(string path)
        {
            if (!Directory.Exists(path)) return false;
            return Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories).Any();
        }


    }
}
