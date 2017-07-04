using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinFormsTest.Utilities
{
    public static class ToolbarItemsSource
    {

        public static ToolbarItem AddItem()
        {
            var button = new ToolbarItem
            {
                Text = "",
                Icon = "icon_add.png"
            };
            return button;
        }

        public static ToolbarItem CloseItem()
        {
            var button = new ToolbarItem
            {
                Text = "",
                Icon = "icon_close.png"
            };
            return button;
        }
    }
}
