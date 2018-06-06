using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8.DatatypesAndScope
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 int32 = 10;
            Int16 int16 = 10;
            Int64 int64 = 10;
            var maxInt32 = Int32.MaxValue;
            string int32AsString = "test";
            int32 = Int32.Parse(int32AsString);
        }
    }
}
