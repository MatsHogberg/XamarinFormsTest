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
	public partial class StepsViewCell : ViewCell
	{
		public StepsViewCell ()
		{
			InitializeComponent();

            // Instantiate each of our views
            StackLayout cellWrapper = new StackLayout();
            StackLayout verticalLayout = new StackLayout();
            Label steps = new Label();
            Label date = new Label();

            // Set Bindings
            steps.SetBinding(Label.TextProperty, "Steps".ToString());
            date.SetBinding(Label.TextProperty, "Date");

            // Set Properties for desired design
            cellWrapper.Padding = 20;
            cellWrapper.BackgroundColor = Color.White;
            verticalLayout.Orientation = StackOrientation.Vertical;

            steps.TextColor = Color.Black;
            steps.FontSize = 30;
            steps.FontAttributes = FontAttributes.Bold;

            date.TextColor = Color.LightGray;
            date.FontSize = 14;
            date.VerticalOptions = LayoutOptions.EndAndExpand;

            // Add Views to the view hierarchy
            verticalLayout.Children.Add(steps);
            verticalLayout.Children.Add(date);
            cellWrapper.Children.Add(verticalLayout);
            View = cellWrapper;
        }
	}
}