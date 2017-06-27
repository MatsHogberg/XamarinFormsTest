using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using XamarinFormsTest.Common;
using Common.Models;
using System.Collections.Generic;

namespace XamarinFormsTest.Droid
{
	[Activity (Label = "XamarinFormsTest", Icon = "@drawable/icon", Theme="@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar; 

			base.OnCreate (bundle);
        
            var x = new Common.GenericGet();
            var y = x.GetAsync<TestUserModel>(GenericGet.Resource.posts, "1", "comments");
            if (!y.IsFaulted && y.Result != null)
            {
                Console.WriteLine("Username: {0}", y);
            }

            global::Xamarin.Forms.Forms.Init (this, bundle);
			LoadApplication (new XamarinFormsTest.App ());
		}
	}
}

