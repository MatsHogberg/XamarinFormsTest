using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using XamarinFormsTest.CustomRenderers;
using Xamarin.Forms.Platform.iOS;
using XamarinFormsTest.iOS.CustomRenderers;

[assembly: ExportRenderer(typeof(SaveButton), typeof(CustomSaveButtonRenderer))]

namespace XamarinFormsTest.iOS.CustomRenderers
{
    public class CustomSaveButtonRenderer : Xamarin.Forms.Platform.iOS.ButtonRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Layer.CornerRadius = 30;
                Control.ClipsToBounds = true;
            }
        }
    }    
}