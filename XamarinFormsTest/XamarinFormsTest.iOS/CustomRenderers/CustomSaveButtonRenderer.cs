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
                
                Console.WriteLine("ButtonFrame: {0}", Control);
                Control.SetNeedsDisplay();
                Control.Layer.CornerRadius = 20;
                Control.ClipsToBounds = true;
            }
        }
    }    
}