using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMessages();
            SayHello("Joe");
            Console.WriteLine(CalculateReward(50));
            Console.ReadLine();
        }

        public static void PrintMessages()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("I'm a C# developer!");
        }

        public static void SayHello(string username)
        {
            Console.WriteLine($"Hello {username}");
        }

        public static int CalculateReward(int moneySpent)
        {
            int rewardPoints = moneySpent * 10;
            return rewardPoints;
        }
    }
}
