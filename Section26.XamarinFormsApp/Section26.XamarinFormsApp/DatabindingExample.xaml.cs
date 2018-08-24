using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Section26.XamarinFormsApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DatabindingExample : ContentPage
	{
	    public int Data { get; set; } = 0;
		public DatabindingExample ()
		{
			InitializeComponent ();
		    BindingContext = Data;
		}

	    private void AddBnt_OnClicked(object sender, EventArgs e)
	    {
	        Data += 1;
	    }

	    private void SubBnt_OnClicked(object sender, EventArgs e)
	    {
	        Data -= 1;
        }
	}
}