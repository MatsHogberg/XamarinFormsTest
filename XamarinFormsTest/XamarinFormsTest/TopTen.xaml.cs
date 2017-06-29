using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Common.Models;
using XamarinFormsTest.ViewCells;

namespace XamarinFormsTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TopTen : ContentPage
	{
		public TopTen()
		{
			InitializeComponent ();


            var listView2 = new ListView()
            {
                ItemsSource = TopTenModel.TopList,
                RowHeight = 100,
                IsPullToRefreshEnabled = true,
                ItemTemplate = new DataTemplate(typeof(TopTenViewCell))
            };
            listView2.RefreshCommand = new Command(() =>
            {
                listView2.IsRefreshing = false;
            });
            Content = listView2;
            
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
