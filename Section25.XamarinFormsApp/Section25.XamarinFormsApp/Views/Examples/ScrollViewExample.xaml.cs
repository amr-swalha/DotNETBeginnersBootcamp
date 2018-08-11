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
	public partial class ScrollViewExample : ContentPage
	{
		public ScrollViewExample ()
		{
			InitializeComponent ();
		}

	    private void ScrollDown_OnClicked(object sender, EventArgs e)
	    {
	        userScrollView.ScrollToAsync(UserEntry, ScrollToPosition.MakeVisible, true);
	    }
	}
}