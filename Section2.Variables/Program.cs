using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2.Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            string StudentName = "Joe";
            int y = 10; 
            int z = x + y; 
            Console.WriteLine(x);
            Console.WriteLine(StudentName);
            Console.WriteLine("X + Y =");
            Console.WriteLine(z);
            Console.WriteLine("Z * 10 =");
            z = z * 10;
            Console.WriteLine(z);

            Console.ReadLine();
        }
    }
}
