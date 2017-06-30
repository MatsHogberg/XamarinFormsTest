using System;
using System.Collections.Generic;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinFormsTest.CustomRenderers;
using XamarinFormsTest.iOS.CustomRenderers;
using XamarinFormsTest.Utilities;

[assembly: ExportRenderer(typeof(CustomTabbedPage), typeof(CustomTabbedPageRenderer))]
namespace XamarinFormsTest.iOS.CustomRenderers
{
    public class CustomTabbedPageRenderer : Xamarin.Forms.Platform.iOS.TabbedRenderer
    {

        readonly nfloat imageYOffset = 5;

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            var tabbar = Element as TabbedPage;
            tabbar.BarBackgroundColor = Xamarin.Forms.Color.White;

            var tabbarAppearance = UITabBar.Appearance;
            tabbarAppearance.SelectedImageTintColor = UIColor.FromRGB(245, 213, 71);
        }

        public override UIViewController SelectedViewController
        {
            get
            {
                if (base.SelectedViewController != null)
                {
                    base.SelectedViewController.TabBarItem.ImageInsets = new UIEdgeInsets(imageYOffset, 0, -imageYOffset, 0);
                }
                return base.SelectedViewController;
            }
            set
            {
                base.SelectedViewController = value;

                foreach (UIViewController viewController in base.ViewControllers)
                {
                    viewController.TabBarItem.ImageInsets = new UIEdgeInsets(imageYOffset, 0, -imageYOffset, 0);
                }
            }
        }
    }
}
