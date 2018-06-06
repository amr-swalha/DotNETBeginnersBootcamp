using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section7.AccessModifires.Protected
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Profile
    {
        protected string PersonName { get; set; }
    }

    public class Student : Profile
    {
        public void PrintStudentName()
        {
            PersonName = "Joe";
        }
    }
}
