using System;

namespace ReflectionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Type type = student.GetType();
            var methods = type.GetMethods();
            var props = type.GetProperties();
            foreach (var item in methods)
            {
                Console.WriteLine(item.Name);
            }
            foreach (var item in props)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public void GetName() => Console.WriteLine(Name);
    }
}
