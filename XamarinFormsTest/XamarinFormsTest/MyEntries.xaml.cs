using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinFormsTest.ViewCells;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Common.Models;

namespace XamarinFormsTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyEntries : ContentPage
    {

        #region Lifecycle
        public MyEntries()
        {
            InitializeComponent();

            var listView = new ListView();
            listView.ItemTemplate = new DataTemplate(typeof(StepsViewCell));
            listView.ItemsSource = Data.StepsList;
            listView.RowHeight = 100;
            listView.IsPullToRefreshEnabled = true;
            listView.RefreshCommand = new Command(() =>
            {
                listView.IsRefreshing = false;
            });
            Content = listView;

            // Setup Interface
            SetupInterface();

        }
        #endregion

        #region User Interface
        private void SetupInterface()
        {
            Title = "Mina Steg";

            var addButton = new ToolbarItem
            {
                Command = new Command(this.AddNewEntryButtonClicked),
                Text = "Lägg Till",
            };
            this.ToolbarItems.Add(addButton);
        }
        #endregion


        #region Fetch Data
        private void GetData()
        {
            var service = new Common.GenericGet();
            var request = service.GetAsync<StepsModel>(Common.GenericGet.Resource.posts);
            if (!request.IsFaulted && request.Result != null)
            {
                Console.WriteLine("Result: {0}", request.Result);
            }
        }
        #endregion


        #region Button Interactions
        private void AddNewEntryButtonClicked()
        {
            OpenNewEntryPage();
        }
        #endregion


        #region Navigation
        private void OpenNewEntryPage()
        {
            var page = new NewEntry();
            var newEntryPage = new NavigationPage(page);
            this.Navigation.PushModalAsync(newEntryPage);

        }
        #endregion


    }
}
