using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Section26.XamarinFormsApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    private void Button_OnClicked(object sender, EventArgs e)
	    {
	        DependencyService.Get<IDependencyService>().LocalAlert("Xamarin forms","Hello native API");
	    }
	}
}
