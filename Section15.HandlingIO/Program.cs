using System.IO;

namespace Section15.HandlingIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //File.Create("D:\\testCreate.txt");
            File.WriteAllText("D:\\testCreate.txt","Hello World");
            StreamWriter stream = new StreamWriter(@"D:\TestStreamWriter.txt");
            stream.WriteLine("From Stream Writer");
            stream.Close();
        }
    }
}
