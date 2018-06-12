using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section10.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            students.Add("Joe");
            var result =  students.FirstOrDefault(x => x == "Joe"); //Get the first item with the value of Joe
        }
    }
}
