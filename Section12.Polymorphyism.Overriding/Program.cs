using System;

namespace Section12.Polymorphyism.Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Main();
            Console.ReadLine();
        }
    }

    public class Root
    {
        public virtual void Main()
        {
            Console.WriteLine("From Root Main");
        }
    }

    public class Child : Root
    {
        public override void Main()
        {
            base.Main();
            Console.WriteLine("From Root Child");
        }
    }
}
