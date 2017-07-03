
using Android.App;
using Android.Content.PM;
using Android.OS;

namespace XamarinFormsTest.Droid
{
    [Activity (Label = "Stepper", Icon = "@drawable/ic_launcher", Theme="@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
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

