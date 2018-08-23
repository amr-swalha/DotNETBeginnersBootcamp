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
	public partial class NavigationExample : ContentPage
	{
		public NavigationExample ()
		{
			InitializeComponent ();
		}

	    private void NavigateSecond_OnClicked(object sender, EventArgs e)
	    {
	        Navigation.PushAsync(new NavigationSecondExample(),true);
	    }
	}
}