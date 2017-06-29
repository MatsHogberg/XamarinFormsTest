using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsTest.ViewCells
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TopTenViewCell : ViewCell
	{
		public TopTenViewCell ()
		{
			InitializeComponent ();

            // Instantiate each of our views
            StackLayout cellWrapper = new StackLayout();
            StackLayout horizontalLayout = new StackLayout();
            StackLayout verticalLayout = new StackLayout();
            Label name = new Label();
            Label steps = new Label();
            Label position = new Label();

            // Set Bindings
            name.SetBinding(Label.TextProperty, "Name");
            steps.SetBinding(Label.TextProperty, "Steps".ToString());
            position.SetBinding(Label.TextProperty, "Position".ToString());

            // Set Properties for desired design
            cellWrapper.Padding = 20;
            cellWrapper.BackgroundColor = Color.White;
            horizontalLayout.Orientation = StackOrientation.Horizontal;
            verticalLayout.Orientation = StackOrientation.Vertical;

            name.TextColor = Color.Black;
            name.FontSize = 26;
            name.FontAttributes = FontAttributes.Bold;

            steps.TextColor = Color.Black;
            steps.FontSize = 12;
            steps.FontAttributes = FontAttributes.Bold;
            steps.VerticalOptions = LayoutOptions.EndAndExpand;

            position.Margin = new Thickness(0, 0, 15, 0);
            position.HorizontalOptions = LayoutOptions.Start;
            position.VerticalOptions = LayoutOptions.Center;
            position.HorizontalTextAlignment = TextAlignment.End;
            position.FontSize = 30;
            position.FontAttributes = FontAttributes.Bold;
            position.TextColor = Color.FromHex("#e6bf0d");

            // Add Views to the view hierarchy
            verticalLayout.Children.Add(name);
            verticalLayout.Children.Add(steps);
            horizontalLayout.Children.Add(position);
            cellWrapper.Children.Add(horizontalLayout);
            horizontalLayout.Children.Add(verticalLayout);
            View = cellWrapper;
        }
	}
}