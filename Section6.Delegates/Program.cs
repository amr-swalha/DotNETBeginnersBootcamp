using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6.Delegates
{
    class Program
    {
        public delegate void Del(string message);
        public static void DelMessage(string message) => Console.WriteLine($"The message: {message}");
        public static void DelOtherMessage(string message) => Console.WriteLine($"The message from another: {message}");
        static void Main(string[] args)
        {
            Del del = DelMessage;
            del.Invoke("Hello Delegate");
            del = DelOtherMessage;
            del.Invoke("Another Message");
            Console.ReadLine();
        }
    }
}
