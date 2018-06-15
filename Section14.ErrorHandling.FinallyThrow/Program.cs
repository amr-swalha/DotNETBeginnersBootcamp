using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section14.ErrorHandling.FinallyThrow
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a number");
                var value = Console.ReadLine();
                int x = 0;
                if (int.TryParse(value.ToString(), out x) == false)
                {
                    throw new Exception("You need to enter a valid number");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }
            finally
            {
                Console.WriteLine("Finally has executed");
            }
            Console.ReadLine();
        }
    }
}
