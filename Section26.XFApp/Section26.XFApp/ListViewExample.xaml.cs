using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Section26.XFApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewExample : ContentPage
	{
        List<Employee> employees = new List<Employee>();
		public ListViewExample ()
		{
			InitializeComponent ();
		    for (int i = 0; i < 5; i++)
		    {
		        employees.Add(new Employee
		        {
                    Name = $"Employee {i}",
                    Title = $"Mr. {i}"
		        });
		    }

		    BindingContext = employees;
		}

	    private void MainList_OnItemTapped(object sender, ItemTappedEventArgs e)
	    {
	        
	    }
	}
}