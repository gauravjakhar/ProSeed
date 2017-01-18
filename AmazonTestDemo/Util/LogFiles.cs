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
            if (status.ToLower().Equals("fail"))
            {
                Console.WriteLine("<img src='C:\\Testing\\icon\\fail.png'/>");
            }
            else
                if (status.ToLower().Equals("pass"))
            {
                Console.WriteLine("<img src='C:\\Testing\\icon\\pass.png'/>");
            }
            else
                if(status.ToLower().Equals("warning"))
            {
                Console.WriteLine("<img src='C:\\Testing\\icon\\warn.png'/>");
            }
            else
                if (status.ToLower().Equals("info"))
            {
                Console.WriteLine("<img src='C:\\Testing\\icon\\info.png'/>");
            }
            Console.WriteLine(message);
            Console.WriteLine("</p>");
        }
    }
}