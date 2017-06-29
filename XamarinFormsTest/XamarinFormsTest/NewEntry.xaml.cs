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
            Title = "Dagens resultat";

            var closeButton = new ToolbarItem
            {
                Command = new Command(this.CloseButtonClicked),
                Text = "Stäng"
            };
            this.ToolbarItems.Add(closeButton);

            GridLayoutMain();
        }


        public void GridLayoutMain()
        {
            var grid = new Grid()
            {
                Padding = new Thickness(20),
                RowSpacing = 15
            };

            // Row Definitions
            grid.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(0.3, GridUnitType.Star)
            });
            grid.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(0.4, GridUnitType.Star)
            });
            grid.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(0.3, GridUnitType.Star)
            });

            // Column Definitions
            grid.ColumnDefinitions.Add(new ColumnDefinition
            {
                Width = new GridLength(1, GridUnitType.Star)
            });

            var entry = new Entry
            {
                Text = "",
                TextColor = Color.Black,
                HorizontalTextAlignment = TextAlignment.Center,
                FontAttributes = FontAttributes.Bold,
                FontSize = 40,
                Keyboard = Keyboard.Numeric,
                Placeholder = "Enter Steps",
                BackgroundColor = Color.LightGray,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };
            entry.Completed += Entry_Completed;
            entry.TextChanged += Entry_TextChanged;

            grid.Children.Add(entry, 0, 0);

            this.Content = grid;
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            var text = ((Entry)sender).Text;
            //Console.WriteLine(text);
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            var text = ((Entry)sender).Text;
            // Console.WriteLine("Send {0} as todays result.", text);
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
