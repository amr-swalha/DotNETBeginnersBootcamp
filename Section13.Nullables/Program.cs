using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section13.Nullables
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            float? f = 8;
            decimal? d = 9;
            if (x.HasValue)
            {
                Console.WriteLine("X has value!");
            }

            int z = x.Value;
            x.GetValueOrDefault(6);
        }
    }
}
