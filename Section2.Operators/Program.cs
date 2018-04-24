using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Arithmetic operators*/
            int x = 5;
            int y = 10;
            int z = 5;
            z = x + y;
            z = x * y; //Multiple
            z = x / y; //Divide
            z = x - y;
            Console.WriteLine(z);
            z += y;
            Console.WriteLine(z);
            z -= y;
            Console.WriteLine(z);
            z *= y;
            Console.WriteLine(z);
            z /= y;
            Console.WriteLine(z);
            Console.WriteLine(10 % 2 == 0);

            /*Arithmetic operators*/
            /*Logical operators*/
            int r = 5;
            int v = 7;
            if (r > 2 & v < 1)
            {
                Console.WriteLine("R and V are greater than 2");
            }
            if (r < 2 | v > 1)
            {
                Console.WriteLine("R and V might be greater than 2");
            }
            if (r > 2 && v < 1)
            {
                Console.WriteLine("R and V might be greater than 2");
            }
            if (r < 2 || v > 1)
            {
                Console.WriteLine("R and V might be greater than 2");
            }
            Console.ReadLine();
            /*Arithmetic operators*/
        }
    }
}
