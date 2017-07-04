using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Concurrent;
using System.Collections.Specialized;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using System.ComponentModel;
using XamarinFormsTest;

namespace Common.Models
{
    public class StepsModel
    {
        public int Steps { get; set; }
        public string Date { get; set; }

        public StepsModel()
        {
            StepsList.CollectionChanged += ContentCollectionChanged;
        }

        #region Object List.
        public static ObservableCollection<StepsModel> StepsList = new ObservableCollection<StepsModel>
        {
            // We start with an empty list.
        };
        #endregion

        public void ContentCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Debug.WriteLine("Item added.");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Debug.WriteLine("Item Deleted.");
                    break;
            }
        }

        public static void AddNew(int steps, string date)
        {
            var newObject = new StepsModel
            {
                Steps = steps,
                Date = date
            };
            StepsList.Add(newObject);
        }
    }
}
