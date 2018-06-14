using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section10.Collections.HashSetCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> dataSet = new HashSet<string>();
            dataSet.Add("Joe");
            dataSet.Add("Joe1");
            dataSet.Add("Joe2");
            dataSet.RemoveWhere(x => x.Length > 3); //To remove all items that meets this condition
            var arr = dataSet.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
