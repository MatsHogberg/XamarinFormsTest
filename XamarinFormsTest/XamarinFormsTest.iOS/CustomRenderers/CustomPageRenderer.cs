using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinFormsTest.CustomRenderers;
using Xamarin.Forms.Platform.iOS;
using XamarinFormsTest.iOS.CustomRenderers;

[assembly: ExportRenderer(typeof(CustomPage), typeof(CustomPageRenderer))]
namespace XamarinFormsTest.iOS.CustomRenderers
{
    public class CustomPageRenderer : PageRenderer
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Console.WriteLine("ViewController is loaded.");
        }
    }
}
