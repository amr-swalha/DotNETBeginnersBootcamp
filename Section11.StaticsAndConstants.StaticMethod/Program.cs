using System;

namespace Section11.StaticsAndConstants.StaticMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticMethodExample.StaticMethod("hello world");
            StaticMethodExample example = new StaticMethodExample();
            //example.StaticMethod("hello world"); //error 
            Console.ReadLine();
        }
    }

    public class StaticMethodExample
    {
        public static void StaticMethod(string msg)
        {
            Console.WriteLine($"Msg from static: {msg}");
        }
    }
}
