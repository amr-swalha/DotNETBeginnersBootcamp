using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section7.AccessModifires.Private
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.SetStudentName("Joe");
        }
    }

    public class Student
    {
        private string StudentName { get; set; }

        public void SetStudentName(string studentName)
        {
            if (studentName != "")
            {
                StudentName = studentName;
            }
            
        }
    }
}
