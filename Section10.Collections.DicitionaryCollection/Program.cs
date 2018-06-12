using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section10.Collections.DicitionaryCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> data = new Dictionary<int, string>();
            data.Add(1,"Joe");
            data.Add(2,"David");
            var result = data[1];
            data.Remove(1);
            data.FirstOrDefault(x => x.Key == 1 && x.Value == "Joe");
        }
    }
}
