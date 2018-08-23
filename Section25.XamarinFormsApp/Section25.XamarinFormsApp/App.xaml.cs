using System;
using Xamarin.Forms;
using Section25.XamarinFormsApp.Views;
using Section25.XamarinFormsApp.Views.Examples;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Section25.XamarinFormsApp
{
	public partial class App : Application
	{
		
		public App ()
		{
			InitializeComponent();


			MainPage = new SwitchExample();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
