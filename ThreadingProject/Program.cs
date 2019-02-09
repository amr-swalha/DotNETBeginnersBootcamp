using System;
using System.Threading;

namespace ThreadingProject
{
    class Program
    {
        public static void ThreadProcess()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Thread Process {i}");
                Thread.Sleep(0);
            }
        }
        static void Main(string[] args)
        {
            Thread threadProcess = new Thread(new ThreadStart(ThreadProcess));
            threadProcess.IsBackground = true;                
            threadProcess.Start();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(0);
            }
            Console.ReadLine();
        }
    }
}
