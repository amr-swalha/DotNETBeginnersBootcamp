using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQProject
{
    public class GroupExample
    {
        public List<Student> students = new List<Student>
        {
            new Student{Age = 18,GPA = 3.4M, Name="Joe"},
            new Student{Age = 18,GPA = 2.4M, Name="Smith"},
            new Student{Age = 18,GPA = 2.4M, Name="Sam"},
            new Student{Age = 19,GPA = 3.7M, Name="David"},
            new Student{Age = 20,GPA = 3.1M, Name="Carl"},
            new Student{Age = 20,GPA = 3.1M, Name="Dan"}
        };
        public void GroupExampleQuery()
        {
            var query = from x in students group x by x.Age;
            Console.WriteLine("=====SimpleWhere=====");
            Console.WriteLine($"Element Count {query.Count()}");
            foreach (var item in query)
            {
                Console.WriteLine("***********************");
                Console.WriteLine(item.Key);
                Console.WriteLine("Items inside this key:");
                foreach (var student in item)
                {
                    Console.WriteLine(student.Name);
                }
                Console.WriteLine("***********************");
            }
            Console.WriteLine("=====SimpleWhere=====");
        }
    }
}
