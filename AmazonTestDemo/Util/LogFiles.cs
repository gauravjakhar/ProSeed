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
            string path = @"C:\Testing\Output\Test.txt";
            FileStream fs = new FileStream(path, FileMode.Create);
            // First, save the standard output.
            //TextWriter tmp = Console.Out;
            sw = new StreamWriter(fs);
            Console.SetOut(sw);
            Console.WriteLine("Hello file");
            Console.WriteLine("Hello World");
            //Console.SetOut(tmp);
        }
        public static void WriteToFileEnd()
        {
            TextWriter tmp = Console.Out;
            Console.SetOut(tmp);
            sw.Close();
        }
    }
}