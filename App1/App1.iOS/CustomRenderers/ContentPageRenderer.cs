using App1.iOS.CustomRenderers;
using App1.Pages;
using System.Drawing;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BaseMainPage), typeof(ContentPageRenderer))]

namespace App1.iOS.CustomRenderers
{
    public class ContentPageRenderer : PageRenderer
    {
        private bool _updatedButtons;

        protected void MoveButtonToLeft()
        {
            var contentPage = this.Element as ContentPage;
            if (contentPage == null || NavigationController == null)
                return;

            var newformButton = NavigationController.TopViewController.NavigationItem.RightBarButtonItems[1];
            NavigationController.TopViewController.NavigationItem.LeftBarButtonItem = newformButton;

            var logoutButton = NavigationController.TopViewController.NavigationItem.RightBarButtonItems[0];
            NavigationController.TopViewController.NavigationItem.RightBarButtonItems = new[] { logoutButton };

            _updatedButtons = true;
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            if (!_updatedButtons)
                MoveButtonToLeft();

            ParentViewController.TabBarController.TabBar.Frame = new RectangleF(0, 719, 1024, 49);
            ParentViewController.TabBarController.TabBar.Hidden = false;
        }
    }
}