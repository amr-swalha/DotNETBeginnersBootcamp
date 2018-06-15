
namespace Section12.Polymorphyism.Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            OverloadingDemo demo = new OverloadingDemo();
            demo.Add(1,2);
            demo.Add("hello","world");
        }
    }

    public class OverloadingDemo
    {
        public void Add(int x, int y)
        {

        }

        public void Add(string x, string y)
        {

        }
        public void Add(int x, string y)
        {

        }
        public void Add(string x, string y, string z)
        {

        }
    }
}
