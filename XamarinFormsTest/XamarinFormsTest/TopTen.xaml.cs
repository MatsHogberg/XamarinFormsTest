using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Common.Models;
using XamarinFormsTest.ViewCells;
using XamarinFormsTest.CustomRenderers;

namespace XamarinFormsTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TopTen : ContentPage
	{
		public TopTen()
		{
			InitializeComponent ();

            var list = new CustomListView()
            {
                ItemsSource = TopTenModel.TopList,
                IsPullToRefreshEnabled = true,
                ItemTemplate = new DataTemplate(typeof(TopTenViewCell))
            };
            list.RefreshCommand = new Command(() =>
            {
                list.IsRefreshing = false;
            });
            Content = list;
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            SetupInterface();
        }

        private void SetupInterface()
        {
            Title = "Topplistan";
        }
    }
}
