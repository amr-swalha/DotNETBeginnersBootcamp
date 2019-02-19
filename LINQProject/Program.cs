using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[5] { 5, 7, 9, 33, 22 };
            var query = from x in data where x > 5 orderby x select x;
            var fulent = data.Where(x => x > 5).OrderBy(x => x).Select(x => x);
            foreach (var num in query)
            {
                Console.WriteLine($"num: {num}");
            }
            Console.ReadLine();
        }
    }
}
