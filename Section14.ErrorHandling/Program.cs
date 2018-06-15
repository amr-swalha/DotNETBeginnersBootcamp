using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section14.ErrorHandling.TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                
                Console.WriteLine(e.Source);
            }
            
            Console.ReadLine();
        }
    }
}
