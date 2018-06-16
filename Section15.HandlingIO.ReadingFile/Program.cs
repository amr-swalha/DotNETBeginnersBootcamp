using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section15.HandlingIO.ReadingFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultAllText = File.ReadAllText("D:\\testCreate.txt");
            Console.WriteLine(resultAllText);
            var resultAllLines = File.ReadAllLines("D:\\testCreate.txt");
            Console.WriteLine(resultAllLines); //Each line is an array object
            StreamReader reader = new StreamReader("D:\\testCreate.txt");
            var resultReader = reader.ReadToEnd();
            Console.WriteLine(resultReader); Console.WriteLine(resultAllText);
            Console.ReadLine();
        }
    }
}
