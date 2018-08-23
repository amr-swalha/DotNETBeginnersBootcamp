using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Section26.XamarinFormsApp.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(AndroidService))]
namespace Section26.XamarinFormsApp.Droid
{
    public class AndroidService :IDependencyService
    {
        public void LocalAlert(string title,string message)
        {
            Android.App.AlertDialog.Builder dialog = new AlertDialog.Builder(Xamarin.Forms.Forms.Context);
            AlertDialog alert = dialog.Create();
            alert.SetTitle(title);
            alert.SetMessage(message);
            alert.SetButton("OK", (c, ev) =>
            {
                // Ok button click task  
            });
            alert.Show();
        }
    }
}