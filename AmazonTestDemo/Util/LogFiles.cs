using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceedSolution.Util
{
    public class LogFiles
    {
        public static StreamWriter sw;
        public static void WriteToFileStart()
        {
            string path = @"C:\Testing\Output\Test.html";
            FileStream fs = new FileStream(path, FileMode.Create);
            sw = new StreamWriter(fs);
            Console.SetOut(sw);
            string TestCaseName = NUnit.Framework.TestContext.CurrentContext.Test.Name;
            Console.WriteLine("<p><font face='verdana' color='blue'>Test : " + TestCaseName + "</font></p>");
        }
        public static void WriteToFileEnd()
        {
            TextWriter tmp = Console.Out;
            Console.SetOut(tmp);
            sw.Close();
        }
        public static void WriteLineInFile(string message, string status)
        {
            Console.WriteLine("<p>");
            switch(status.ToLower())
            {
                case "fail":
                    Console.WriteLine("<img src='C:\\Testing\\icon\\fail.png'/>");
                    break;
                case "pass":
                    Console.WriteLine("<img src='C:\\Testing\\icon\\pass.png'/>");
                    break;
                case "warning":
                    Console.WriteLine("<img src='C:\\Testing\\icon\\warn.png'/>");
                    break;
                case "info":
                    Console.WriteLine("<img src='C:\\Testing\\icon\\info.png'/>");
                    break;
            }     
            Console.WriteLine(message);
            Console.WriteLine("</p>");
        }
    }
}