using System;
using Xamarin.Forms;

namespace XamarinFormsTest.CustomRenderers
{
    public class CustomListView : ListView
    {

        Label headerTitle = new Label();

        public CustomListView()
        {
            OverallUI();
        }

        private void OverallUI()
        {
            SeparatorColor = Color.FromRgb(230, 230, 230);
            RowHeight = 100;
        }

        public void SetupHeader(string title)
        {
            var grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(60) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.8, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.2, GridUnitType.Star) });

            // Setup the Header Title.
            headerTitle.VerticalOptions = LayoutOptions.Center;
            headerTitle.HorizontalOptions = LayoutOptions.Start;
            headerTitle.Text = title;
            headerTitle.TextColor = Color.LightGray;
            headerTitle.FontSize = 18;
            headerTitle.FontAttributes = FontAttributes.Bold;
            headerTitle.Margin = new Thickness(20, 0, 0, 0);

            // Setup the Sort Button.
            var sortButton = new Button {
                Text = "Sortera".ToUpper(),
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold,
                FontSize = 9,
                BackgroundColor = Color.Transparent,
                HorizontalOptions = LayoutOptions.Center
            };
            sortButton.Clicked += SortButton_Clicked;

            // Add the views to the grids columns.
            grid.Children.Add(headerTitle, 0, 0);
            grid.Children.Add(sortButton, 1, 0);

            // Add The grid to the listviews header.
            Header = grid;
        }

        private void SortButton_Clicked(object sender, EventArgs e) {}
    }
}
