using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section11.StaticsAndConstants.StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleStaticClass.MessageFromStatic();
            ExampleStaticClass.MyProp = "From Main Method";
            CallStatic stCallStatic = new CallStatic();
            stCallStatic.PrintMyProp();
            Console.ReadLine();
        }
    }

    public static class ExampleStaticClass
    {
        public static string MyProp { get; set; }

        public static void MessageFromStatic()
        {
            Console.WriteLine("Hello from static");
        }
    }

    public class CallStatic
    {
        public void PrintMyProp()
        {
            Console.WriteLine($"Value from Call static {ExampleStaticClass.MyProp}");
        }    }
}
