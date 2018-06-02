using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section4.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Lecture 22- C# class object*/
            Student student = new Student();
            student.StudentName = "Joe";
            student.PrintStudentName();
            student.StudentGPA = "2.9";
            student.PrintGPA();
            Student david = new Student();
            david.StudentName = "David";
            david.PrintStudentName();
            david.StudentGPA = "3.2";
            david.PrintGPA();
            /*Lecture 22- C# class object*/
            /*Lecture 23- C# Property*/
            student.Age = 25;
            student.PrintAge();
            /*Lecture 23- C# Property*/
            /*Lecture 24- C# Class Constructor*/
            Student constructorExample = new Student("David","3.5");
            constructorExample.PrintStudentName();
            constructorExample.PrintGPA(); 
            /*Lecture 24- C# Class Constructor */
            /*Lecture 25- C# Class Inheritance */
            Student inhertanceStudent = new Student();
            inhertanceStudent.PrintPhone();
            /*Lecture 25- C# Class Inheritance */
            /*Lecture 26- C# Interface */
            /*Lecture 26- C# Interface */
            Console.ReadLine();
        }
    }
    /*Lecture 25 - C# Class Inheritance*/
    public class Profile
    {
        public string Phone { get; set; }

        public void PrintPhone()
        {
            Console.WriteLine($"Phone #:{Phone}");
        }
    }
    /*Lecture 25 - C# Class Inheritance*/
    /*Lecture 21- C# classes*/

    public class Student : Profile
    {
        public string StudentName { get; set; }
        public string StudentGPA{get;set;}
        private int _age = 0;

        public Student()
        {
            StudentName = "New Student";
            StudentGPA = "0.0";
            Phone = "555";
        }

        ~Student()
        {
            StudentName = null;
            Console.WriteLine("GC Called");
        }
        public Student(string studentName,string gpa)
        {
            StudentName = studentName;
            StudentGPA = gpa;
        }
        public int Age
        {
            get => _age;
            set
            {
                if (value > -1)
                {
                    _age = value;
                }
            }
        }
        public void PrintStudentName()
        {
            Console.WriteLine($"Welcome, {StudentName}");
        }

        public void PrintGPA()
        {
            Console.WriteLine($"His GPA: {StudentGPA}");
        } 
        public void PrintAge()
        {
            Console.WriteLine($"His Age: {Age}");
        }
    }
    /*Lecture 21- C# classes*/
}
