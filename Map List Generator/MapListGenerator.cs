using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map_List_Generator
{
    public class MapListGenerator
    {
        static void Main(string[] args)
        {
            string location = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo d = new DirectoryInfo(location);
            FileInfo[] files = d.GetFiles("*.bsp");

            if (files.Length < 1) return;

            string output = String.Format(@"{0}mapcycle.txt", location);
            StreamWriter write = new StreamWriter(output);
            write.AutoFlush = true;

            foreach(FileInfo file in files)
            {
                string temp = file.Name.Replace(".bsp", "");
                write.WriteLine(temp);
            }

            Thread.Sleep(10);
            Console.Beep();
        }
    }
}
