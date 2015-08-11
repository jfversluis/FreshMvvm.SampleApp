using App1.iOS.CustomRenderers;
using App1.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BaseSubPage), typeof(BaseSubPageRenderer))]

namespace App1.iOS.CustomRenderers
{
    public class BaseSubPageRenderer : PageRenderer
    {
        public override void ViewWillAppear(bool animated)
        {
            ParentViewController.TabBarController.TabBar.Hidden = true;

            base.ViewWillAppear(animated);
        }
    }
}