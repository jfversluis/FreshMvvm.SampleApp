using App1.iOS.CustomRenderers;
using App1.Pages;
using System.Drawing;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BaseSubPage), typeof(BaseSubPageRenderer))]

namespace App1.iOS.CustomRenderers
{
    public class BaseSubPageRenderer : PageRenderer
    {
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            ParentViewController.TabBarController.TabBar.Frame = new RectangleF((float)-1000, (float)-1000, (float)0, (float)0);
            ParentViewController.TabBarController.TabBar.Hidden = true;
        }
    }
}