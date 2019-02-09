using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

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
            //string getStringTask = await client.GetStringAsync("http://msdn.microsoft.com");
            await GetTask("Task method");
        }
        public static Task GetTask(string data)
        {
            Thread.Sleep(2000);
            return Task.Run(() =>
            {
                Console.WriteLine(data);
            });
        }
    }
}
