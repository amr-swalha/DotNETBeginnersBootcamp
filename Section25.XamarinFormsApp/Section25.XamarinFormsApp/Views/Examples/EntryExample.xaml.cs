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
	public partial class EntryExample : ContentPage
	{
		public EntryExample ()
		{
			InitializeComponent ();
		}

	    private void Entry_OnCompleted(object sender, EventArgs e)
	    {
	        var txt = (Entry) sender;
	        Debug.WriteLine($"User is done writing {txt.Text}");
	    }

	    private void Entry_OnTextChanged(object sender, TextChangedEventArgs e)
	    {
	        var txt = (Entry)sender;
	        Debug.WriteLine($"User is now writing {txt.Text}");
        }
	}
}