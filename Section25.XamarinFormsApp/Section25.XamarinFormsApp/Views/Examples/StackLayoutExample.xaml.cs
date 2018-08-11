using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Section25.XamarinFormsApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StackLayoutExample : ContentPage
	{
		public StackLayoutExample()
		{
			InitializeComponent ();
		}

	    protected override void OnAppearing()
	    {
	        base.OnAppearing();
            Debug.WriteLine("Home Page is Appearing");
	    }
	}
}