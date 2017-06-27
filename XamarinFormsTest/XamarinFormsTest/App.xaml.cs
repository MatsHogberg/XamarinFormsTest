using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinFormsTest
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            SetupNavigation();
        }

        public static void SetupNavigation()
        {
            Current.MainPage = new TabbedPage
            {
                Children =
                {
                    new NavigationPage(new MyEntries())
                    {
                        Title = "Mina Steg",
                        // Icon = "tab-me.png"
                    },
                    new NavigationPage(new TopTen())
                    {
                        Title = "Topplistan",
                        // Icon = "tab-star.png",
                    }
                }
            };
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
