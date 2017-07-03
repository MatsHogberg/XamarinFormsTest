using System;
using System.Collections.Generic;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinFormsTest.CustomRenderers;
using XamarinFormsTest.iOS.CustomRenderers;

[assembly: ExportRenderer(typeof(CustomListView), typeof(CustomListViewRenderer))]
namespace XamarinFormsTest.iOS.CustomRenderers
{

    public class CustomListViewRenderer : Xamarin.Forms.Platform.iOS.ListViewRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.AllowsSelection = false;
                
            }
        }
    }
}
