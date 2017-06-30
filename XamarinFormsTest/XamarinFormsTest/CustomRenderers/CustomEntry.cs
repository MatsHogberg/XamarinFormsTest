using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace XamarinFormsTest.CustomRenderers
{
    public class CustomEntry : Entry
    {
        
        public CustomEntry()
        {
            SetupUI();
        }

        private void SetupUI()
        {
            Text = "";
            Placeholder = "Ange steg";
            TextColor = Color.Black;
            HorizontalTextAlignment = TextAlignment.Center;
            FontAttributes = FontAttributes.Bold;
            FontSize = 40;
            Keyboard = Keyboard.Numeric;
            BackgroundColor = Color.White;
            VerticalOptions = LayoutOptions.Center;
            HorizontalOptions = LayoutOptions.Center;
        }
    }
}
