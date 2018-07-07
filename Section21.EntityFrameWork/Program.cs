using System;
using System.Linq;

namespace Section21.EntityFrameWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AppContext context = new AppContext();
            context.Students.Remove(new Student{Id = 9});
            
            context.SaveChanges();
            Console.ReadLine();
        }
    }
}
