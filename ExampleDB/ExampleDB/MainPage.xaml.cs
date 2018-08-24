using System;
using ExampleDB.Models;
using Xamarin.Forms;

namespace ExampleDB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            App.Database.SaveStudentAsync(new Student {StudentName = EntName.Text});
            DisplayAlert("Student Added Successfully", $"Student {EntName.Text} has been added successfully", "OK");
        }

        private async void BntGetById_OnClicked(object sender, EventArgs e)
        {
            var student = await App.Database.GetStudentByIdAsync(int.Parse(EntNameById.Text));
            if (student == null)
            {
                await DisplayAlert("Not Found", "Please check the Id", "OK");
            }

            LblStudentName.Text = student.StudentName;
        }
    }
}
