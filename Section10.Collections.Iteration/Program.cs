using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section10.Collections.Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lstString = new List<string>();
            Dictionary<int,string> dictionary = new Dictionary<int, string>();
            HashSet<string> hashSet = new HashSet<string>();
            for (int i = 0; i < 100; i++)
            {
                dictionary.Add(i,i.ToString());
                lstString.Add(i.ToString());
                hashSet.Add(i.ToString());
            }

            for (int i = 0; i < lstString.Count; i++)
            {
                Console.WriteLine(lstString[i]);
            }

            foreach (var lstItem in lstString)
            {
                Console.WriteLine(lstItem);
            }

            foreach (var dicitionaryItem in dictionary)
            {
                Console.WriteLine($"Key:{dicitionaryItem.Key}, Value:{dicitionaryItem.Value}");
            }

            foreach (var hashsetItem in hashSet)
            {
                Console.WriteLine(hashsetItem);
            }
            Console.ReadLine();
        }
    }
}
