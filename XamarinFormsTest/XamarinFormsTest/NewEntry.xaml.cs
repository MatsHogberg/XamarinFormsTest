using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewEntry : ContentPage
    {
        public NewEntry()
        {
            InitializeComponent();
            SetupInterface();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        #region User Interface
        private void SetupInterface()
        {
            var closeButton = new ToolbarItem
            {
                Command = new Command(this.CloseButtonClicked),
                Text = "Stäng"
            };
            this.ToolbarItems.Add(closeButton);

            SetupStackLayout();
        }

        private void SetupStackLayout()
        {
            var layout = new StackLayout();
            var button = new Button
            {
                Text = "StackLayout",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            var yellowBox = new BoxView { Color = Color.Yellow, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand };
            var greenBox = new BoxView { Color = Color.Green, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand };
            var blueBox = new BoxView
            {
                Color = Color.Blue,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HeightRequest = 75
            };

            layout.Children.Add(button);
            layout.Children.Add(yellowBox);
            layout.Children.Add(greenBox);
            layout.Children.Add(blueBox);
            layout.Spacing = 10;
            Content = layout;
        }

        #endregion

        #region Button Interactions
        public void CloseButtonClicked()
        {
            this.Navigation.PopModalAsync();
        }
        #endregion
    }
}
