using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Section25.XamarinFormsApp.Views.Examples
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SwitchExample : ContentPage
	{
		public SwitchExample ()
		{
			InitializeComponent ();
		}

	    private void SwitchBnt_OnToggled(object sender, ToggledEventArgs e)
	    {
	        if (e.Value)
	        {
	            DisplayAlert("Switch", "Toggled On", "Ok");
	        }
	        else
	        {
	            DisplayAlert("Switch", "Toggled Off", "Ok");
            }
	    }
	}
}