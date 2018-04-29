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
            Console.ReadLine();
        }
    }
    /*Lecture 21- C# classes*/
    public class Student
    {
        public string StudentName { get; set; }
        public string StudentGPA{get;set;}
        private int _age = 0;

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
