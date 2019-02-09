using System;
using System.Net.Http;

namespace AsynchronousProject
{
    class Program
    {
        static void Main(string[] args)
        {
            TestAsync();
            Console.ReadLine();
        }
        public static async void TestAsync()
        {
            HttpClient client = new HttpClient();
            string getStringTask = await client.GetStringAsync("http://msdn.microsoft.com");
            Console.WriteLine(getStringTask);
        }
    }
}
