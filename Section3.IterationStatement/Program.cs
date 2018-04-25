using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section3.IterationStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"The value of i is: {i}");
                if (i > 5)
                {
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
