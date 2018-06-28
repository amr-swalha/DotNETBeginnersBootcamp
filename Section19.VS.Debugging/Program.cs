using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section19.VS.Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            decimal z = 0.0M;
            for (int i = 0; i < 10; i++)
            {
                x += 5;
                y += i;
                z += i * y * x;
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
