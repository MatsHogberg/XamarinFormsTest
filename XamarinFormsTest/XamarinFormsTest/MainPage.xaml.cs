using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoToTabs_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(
                new TabbedPage
                {
                    Children =
                    {
                        new NewEntry(),
                        new MyEntries(),
                        new TopTen()
                    }
                });
        }
    }
}
