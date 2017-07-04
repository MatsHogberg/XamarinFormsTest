using System;
using System.Diagnostics;
using System.Collections.Generic;
using XamarinFormsTest.ViewCells;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Common.Models;
using XamarinFormsTest.CustomRenderers;
using XamarinFormsTest.Utilities;

namespace XamarinFormsTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyEntries : ContentPage
    {

        #region Lifecycle
        public MyEntries()
        {
            InitializeComponent();
            var list = new CustomListView()
            {
                ItemTemplate = new DataTemplate(typeof(StepsViewCell)),
                ItemsSource = StepsModel.StepsList,
                IsPullToRefreshEnabled = true,
            };
            list.RefreshCommand = new Command(() =>
            {
                list.IsRefreshing = false;
            });
            Content = list;
            list.SetupHeader("Senaste");

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
                Text = "",
                Icon = "icon_add.png"
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
                // Console.WriteLine("Result: {0}", request.Result);
            }
        }
        #endregion


        #region Button Interactions
        private void AddNewEntryButtonClicked()
        {
            //OpenNewEntryPage();
            Console.WriteLine("Button Clicked");

            var monkeyList = new List<string>();
            monkeyList.Add("Baboon");
            monkeyList.Add("Capuchin Monkey");
            monkeyList.Add("Blue Monkey");
            monkeyList.Add("Squirrel Monkey");
            monkeyList.Add("Golden Lion Tamarin");
            monkeyList.Add("Howler Monkey");
            monkeyList.Add("Japanese Macaque");

            var picker = new Picker { Title = "Select a monkey" };
            picker.ItemsSource = monkeyList;
            picker.Focus();
        }
        #endregion


        #region Navigation
        async void OpenNewEntryPage()
        {
            var page = new NewEntry();
            var newEntryPage = new NavigationPage(page);
            await this.Navigation.PushModalAsync(newEntryPage);
        }
        #endregion


    }
}
