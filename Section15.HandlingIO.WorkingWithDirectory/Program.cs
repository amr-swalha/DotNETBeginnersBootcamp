using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Section15.HandlingIO.WorkingWithDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            var directory = "D:\\Demo";
            Directory.CreateDirectory(directory);
            Directory.GetCreationTime(directory);
            if (Directory.Exists(directory))
            {
                Console.WriteLine("Directory is there!");
            }

            File.Create(directory + "\\test.txt");
            var files = Directory.GetFiles(directory);
            Console.WriteLine("Files are:");
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i]);
            }

            Console.ReadLine();
        }
    }
}
