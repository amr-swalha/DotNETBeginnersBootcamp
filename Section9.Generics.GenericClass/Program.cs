using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section9.Generics.GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericPrint<int> intPrint = new GenericPrint<int>();
            intPrint.PrintData(5);
            GenericPrint<decimal> decimalPrint = new GenericPrint<decimal>();
            decimalPrint.PrintData(55.5M);
        }
    }

    public class GenericPrint<T>
    {
        public T Data { get; set; }

        public void PrintData(T data)
        {
            Console.WriteLine(data.ToString());
        }

        public T Add(T data)
        {
            return data;
        }
    }

}
