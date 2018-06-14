using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section11.StaticsAndConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticExample example = new StaticExample();
            example.Method1();
            example.Method2();
            StaticData.x++;
            example.Method1();
            example.Method2();
            Console.ReadLine();
        }
    }

    public class StaticExample
    {


        public void Method1()
        {
            Console.WriteLine("Value of x before increment");
            Console.WriteLine(StaticData.x);
            Console.WriteLine("x is incremented by 1 - Method1");
            StaticData.x++;
            Console.WriteLine(StaticData.x);
        }
        public void Method2()
        {
            Console.WriteLine("Value of x before increment");
            Console.WriteLine(StaticData.x);
            Console.WriteLine("x is incremented by 2 - Method2");
            StaticData.x++;
            Console.WriteLine(StaticData.x);
        }
    }

    public class StaticData
    {
        public static int x = 0;
    }
}
