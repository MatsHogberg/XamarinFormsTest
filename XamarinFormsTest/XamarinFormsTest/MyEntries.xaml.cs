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

        CustomListView listView = new CustomListView();

        #region Lifecycle
        public MyEntries()
        {
            InitializeComponent();
            // Get Data.
            GetData();      
            // Setup Interface
            SetupInterface();
        }
        #endregion



        #region User Interface
        private void SetupInterface()
        {
            Title = "Mina Steg";

            var addButton = ToolbarItemsSource.AddItem();
            addButton.Command = new Command(this.AddNewEntryButtonClicked);
            this.ToolbarItems.Add(addButton);
        }

        public void BindResultToData()
        {

            listView.ItemTemplate = new DataTemplate(typeof(StepsViewCell));
            listView.ItemsSource = StepsModel.StepsList;
            listView.IsPullToRefreshEnabled = true;
            listView.RefreshCommand = new Command(() =>
            {
                listView.IsRefreshing = false;
            });
            listView.SetupHeader("Senaste");

            // Add The list view to the views content.
            Content = listView;
            /*
            if (StepsModel.StepsList.Count > 1)
            {

                listView.ItemTemplate = new DataTemplate(typeof(StepsViewCell));
                listView.ItemsSource = StepsModel.StepsList;
                listView.IsPullToRefreshEnabled = true;
                listView.BindingContextChanged += ListView_BindingContextChanged;
                listView.RefreshCommand = new Command(() =>
                {
                    listView.IsRefreshing = false;
                });
                listView.SetupHeader("Senaste");

                // Add The list view to the views content.
                Content = listView;
            } else
            {
                ShowNoResultMessage();
            }*/
        }

        #endregion


        #region Fetch Data
        public void GetData()
        {
            var service = new Common.GenericGet();
            var request = service.GetAsync<StepsModel>(Common.GenericGet.Resource.posts);
            if (!request.IsFaulted && request.Result != null)
            {
                // Console.WriteLine("Result: {0}", request.Result);
            }
            BindResultToData();
        }
        #endregion

        private void ShowNoResultMessage()
        {
            var label = new Label()
            {
                Text = "No Results Found.",
                TextColor = Color.DarkGray,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            StackLayout stack = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
            };

            stack.Children.Add(label);
            Content = stack;
        }

        #region Button Interactions
        private void AddNewEntryButtonClicked()
        {
            OpenNewEntryPage();
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
