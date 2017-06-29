using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsTest.Utilities;
namespace XamarinFormsTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewEntry : ContentPage
    {

        Entry stepsEntry = new Entry();

        public NewEntry()
        {
            InitializeComponent();
            SetupInterface();
        }

        #region User Interface
        private void SetupInterface()
        {
            Title = "Dagens resultat";
            BackgroundColor = Color.White;
            this.ToolbarItems.Add(CloseButton());
            GridLayoutMain();
        }

        // Main Page Grid View.
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
                Height = new GridLength(0.15, GridUnitType.Star)
            });

            // Column Definitions
            grid.ColumnDefinitions.Add(new ColumnDefinition
            {
                Width = new GridLength(1, GridUnitType.Star)
            });

            // Add subviews to grid.
            grid.Children.Add(StepsEntry(), 0, 0);
            grid.Children.Add(SaveButton(), 0, 2);

            this.Content = grid;
        }

        // Entry view to let the user type in their daily result.
        private Entry StepsEntry()
        {
            stepsEntry.Text = "";
            stepsEntry.TextColor = Color.Black;
            stepsEntry.HorizontalTextAlignment = TextAlignment.Center;
            stepsEntry.FontAttributes = FontAttributes.Bold;
            stepsEntry.FontSize = 40;
            stepsEntry.Keyboard = Keyboard.Numeric;
            stepsEntry.Placeholder = "Antal steg";
            stepsEntry.BackgroundColor = Color.White;
            stepsEntry.VerticalOptions = LayoutOptions.Center;
            stepsEntry.HorizontalOptions = LayoutOptions.Center;
            stepsEntry.Completed += Entry_Completed;
            return stepsEntry;
        }

        // Save Button which appears at the bottom of the screen. 
        private Button SaveButton()
        {
            var button = new Button
            {
                Text = "Spara",
                TextColor = Color.White,
                BackgroundColor = Colors.StepsGreen,
                FontSize = 18,
                FontAttributes = FontAttributes.Bold
            };
            button.Clicked += Button_Clicked;
            return button;
        }

        // Navigation Button to Close the view.
        public ToolbarItem CloseButton()
        {
            var closeButton = new ToolbarItem
            {
                Command = new Command(this.CloseButtonClicked),
                Text = "Stäng"
            };
            return closeButton;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // This is where we want to pass the entry input to save it on the server.
            // When thats done we close this page and update the main views (MyEntries and TopTen).

            // Check if input is valid.
            CheckIfInputsOK();
        }

        // Show An alert about why the user cant save the result.
        async void DisplayNoStepsAlert()
        {
            await DisplayAlert(
                "Inga steg?", 
                "Innan du kan spara måste du ange hur många steg du har gått idag.", 
                "OK");
        }

        // Validate if the text entry is empty or not.
        private void CheckIfInputsOK()
        {
            if (this.stepsEntry.Text == null || this.stepsEntry.Text.Length == 0)
            {
                DisplayNoStepsAlert();
            }
            else
            {
                Navigation.PopModalAsync();
            }
        }

        // When Done Button in keyboard is clicked.
        private void Entry_Completed(object sender, EventArgs e)
        {
            CheckIfInputsOK();
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
