using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Common.Models
{
    public class StepsModel
    {
        public int Steps { get; set; }
        public string Date { get; set; }
    }

    public class Data
    {
        #region Simple String List.
        public static List<string> StringList = new List<string>
        {
            "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten"
        };
        #endregion

        #region Object List.     
        public static ObservableCollection<StepsModel> StepsList = new ObservableCollection<StepsModel>
        {
            new StepsModel { Steps=2000, Date="2017-06-27" },
            new StepsModel { Steps=2460, Date="2017-06-26" },
            new StepsModel { Steps=22300, Date="2017-06-25" },
            new StepsModel { Steps=6300, Date="2017-06-24" },
            new StepsModel { Steps=7402, Date="2017-06-23" },
            new StepsModel { Steps=10236, Date="2017-06-22" },
            new StepsModel { Steps=9872, Date="2017-06-21" },
        };
        #endregion
    }
}
