using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8.DatatypesAndScope.FloatType
{
    class Program
    {
        static void Main(string[] args)
        {
            float floatType = 0.1f;
            float floatConvert = float.Parse("5.55");
            int r = 66;
            float convert =r + 0.05f;
            int x = int.Parse(convert.ToString("#"));
            Console.ReadLine();
        }
    }
}
