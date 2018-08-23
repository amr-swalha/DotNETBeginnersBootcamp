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
	public partial class NavigationThirdExample : ContentPage
	{
		public NavigationThirdExample ()
		{
			InitializeComponent ();
		}

	    private void Button_OnClicked(object sender, EventArgs e)
	    {
	        Navigation.PopToRootAsync();
	    }
	}
}