using System;

namespace LINQProject
{
    class Program
    {
        static void Main(string[] args)
        {
            WhereExample whereExample = new WhereExample();
            //whereExample.SimpleWhere();
            GroupExample groupExample = new GroupExample();
            groupExample.GroupExampleQuery();
            Console.ReadLine();
        }
    }
}
