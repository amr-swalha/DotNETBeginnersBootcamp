using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section9.Generics.Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary
            Dictionary<int,string> intDictionary = new Dictionary<int, string>();
            intDictionary.Add(1,"hello");
            Dictionary<string,string> stringDictionary = new Dictionary<string, string>();
            stringDictionary.Add("first","value");
            //Dictionary
            //Stack
            Stack<int> intStack = new Stack<int>();
            intStack.Push(4);
            Stack<Decimal> decimals = new Stack<decimal>();
            decimals.Push(55.6m);//Stack
            Stack<Student> studentStack = new Stack<Student>();
            studentStack.Push(new Student{Name = "Amr"});
            //Queue
            Queue<string> stringQueue = new Queue<string>();
            stringQueue.Enqueue("new item in queue");
            //Queue
        }

        public class Student
        {
            public string Name { get; set; }
        }
    }
}
