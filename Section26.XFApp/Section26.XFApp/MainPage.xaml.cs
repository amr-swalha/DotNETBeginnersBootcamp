using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Section26.XFApp
{
    public partial class MainPage : ContentPage
    {
        public int Value { get; set; } = 0;
        Employee employee = new Employee { Name = "Amr", Title = "Senior" };
        public MainPage()
        {
            InitializeComponent();
            
            BindingContext = employee;
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Title { get; set; }
    }
}
