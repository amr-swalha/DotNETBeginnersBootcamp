using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Section25.XamarinFormsApp.Views.Examples
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ButtonExample : ContentPage
	{
		public ButtonExample ()
		{
			InitializeComponent ();
		}

	    private void UserButton_OnClicked(object sender, EventArgs e)
	    {
	        Debug.WriteLine("User has clicked/tapped a button");
	    }

	    private void UserButton_OnPressed(object sender, EventArgs e)
	    {
	        Debug.WriteLine("User has pressed the button");
	    }

	    private void UserButton_OnReleased(object sender, EventArgs e)
	    {
	        Debug.WriteLine("User has released the button");
        }
	}
}