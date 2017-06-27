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
	[Activity (Label = "XamarinFormsTest", Icon = "@drawable/ic_launcher", Theme="@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar; 

			base.OnCreate(bundle);

            Window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#F5D547"));

            global::Xamarin.Forms.Forms.Init (this, bundle);
			LoadApplication (new XamarinFormsTest.App ());
		}
	}
}

