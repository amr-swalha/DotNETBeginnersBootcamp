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
            /*For iteration*/
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"The value of i is: {i}");
                if (i > 5)
                {
                    break;
                }
            }
            /*For iteration*/
            /*While iteration*/
            int z = 0;
            while (z < 10)
            {
                Console.WriteLine(z);
                if (z == 5)
                {
                    break;
                }
                z += 1;
            }
            /*While iteration*/

            /*forEach iteration*/
            string x = "Hello World!";
            foreach (var letter in x)
            {
                Console.WriteLine(letter);
            }
            /*forEach iteration*/
            Console.ReadLine();
        }
    }
}
