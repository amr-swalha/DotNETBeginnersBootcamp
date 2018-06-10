using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8.DatatypesAndScope.DecimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal newDecimal = 55.4m;
            int intToDecimal = 55;
            decimal newConvert = intToDecimal;
            Console.WriteLine(decimal.Floor(newDecimal)); 
            Console.WriteLine(decimal.Ceiling(newDecimal));
            Console.ReadLine();
        }
    }
}
