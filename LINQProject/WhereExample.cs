using System;
using System.Linq;

namespace LINQProject
{
    public class WhereExample
    {
        int[] dataSource = new int[10] { 2, 9, 8, 7, 14, 5, 99, 102, 587, 16 };
        public void SimpleWhere()
        {
            var query = from x in dataSource where IsMatched(x) select x;
            Console.WriteLine("=====SimpleWhere=====");
            Console.WriteLine($"Element Count {query.Count()}");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=====SimpleWhere=====");
        }
        public bool IsMatched(int value)
        {
            return value > 10 || value < 100;
        }
    }
}
