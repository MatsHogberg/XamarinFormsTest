using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Common.Models
{
    public class TopTenModel
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public int Steps { get; set; }
        public int Position { get; set; }
    
        #region Object List.     
        public static ObservableCollection<TopTenModel> TopList = new ObservableCollection<TopTenModel>
        {
            new TopTenModel { Position = 1, Name = "Martin", Steps = 401023 },
            new TopTenModel { Position = 2, Name = "Mats", Steps = 37023 },
            new TopTenModel { Position = 3, Name = "Ammi", Steps = 32103 },
            new TopTenModel { Position = 4, Name = "Ricardo", Steps = 30103 },
            new TopTenModel { Position = 5, Name = "Mattias", Steps = 27102 },
            new TopTenModel { Position = 6, Name = "Bengt", Steps = 22103 },
            new TopTenModel { Position = 7, Name = "Martin", Steps = 22023 },
            new TopTenModel { Position = 8, Name = "Emil", Steps = 21403 },
            new TopTenModel { Position = 9, Name = "Markus", Steps = 20104 },
            new TopTenModel { Position = 10, Name = "Fredrik", Steps = 18923 },
        };
        #endregion
    }
}
