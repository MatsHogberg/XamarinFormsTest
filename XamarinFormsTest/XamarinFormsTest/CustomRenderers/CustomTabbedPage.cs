using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinFormsTest.Utilities;
namespace XamarinFormsTest.CustomRenderers
{
    public class CustomTabbedPage : TabbedPage
    {
        public CustomTabbedPage()
        {
            SetupUI();
            SetupChildren();
        }

        private void SetupUI()
        {
            BarBackgroundColor = Colors.StepsYellow;
        }

        private void SetupChildren()
        {
            Children.Add(FirstPage());
            Children.Add(SecondPage());
        }

        private NavigationPage FirstPage()
        {
            var page = new NavigationPage(new MyEntries())
            {
                Title = null,
                Icon = "icon_walk.png"
            };
            return page;
        }

        private NavigationPage SecondPage()
        {
            var page = new NavigationPage(new TopTen())
            {
                Title = "",
                Icon = "icon_star.png"
            };
            return page;
        }
    }
}
