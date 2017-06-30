using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinFormsTest.Utilities;

namespace XamarinFormsTest.CustomRenderers
{
    public class SaveButton : Button
    {
        public SaveButton()
        {
            SetupUI();
        }

        private void SetupUI()
        {
            Text = "Spara";
            TextColor = Color.White;
            BackgroundColor = Colors.StepsYellowDark;
            FontSize = 18;
            FontAttributes = FontAttributes.Bold;
        }
    }
}
