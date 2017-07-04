using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinFormsTest.CustomRenderers;
using XamarinFormsTest.iOS.CustomRenderers;

[assembly: ExportRenderer(typeof(CustomTabbedPage), typeof(CustomTabbedPageRenderer))]
namespace XamarinFormsTest.iOS.CustomRenderers
{
    public class CustomTabbedPageRenderer : Xamarin.Forms.Platform.iOS.TabbedRenderer
    {

        readonly UIEdgeInsets insets = new UIEdgeInsets(5, 0, -5, 0);
        
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            var tabbar = Element as TabbedPage;
            tabbar.BarBackgroundColor = Xamarin.Forms.Color.White;

            var tabbarAppearance = UITabBar.Appearance;
            tabbarAppearance.SelectedImageTintColor = UIColor.FromRGB(245, 213, 71);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            if (TabBar.Items != null)
            {
                var items = TabBar.Items;
                for (int i = 0; i < items.Length; i++)
                {
                    items[i].ImageInsets = insets;
                }
            }
        }
    }
}
