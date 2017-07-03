using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinFormsTest.CustomRenderers
{
    public class CustomListView : ListView
    {

        public CustomListView()
        {
            OverallUI();
        }

        private void OverallUI()
        {
            SeparatorColor = Color.FromRgb(230, 230, 230);
            RowHeight = 100;
        }
    }
}
