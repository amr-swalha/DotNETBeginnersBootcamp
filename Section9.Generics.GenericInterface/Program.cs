using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section9.Generics.GenericInterface
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public interface IStudent<T>
    {
        T Name { get; set; }

        T Process(T value);
    }

    public class Student : IStudent<string>
    {
        public string Name { get; set; }
        public string Process(string value)
        {
            return value;
        }
    }
}
