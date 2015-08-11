using App1.PageModels;
using FreshMvvm;
using Xamarin.Forms;

namespace App1.Pages
{
    public class BaseMainPage : ContentPage
    {
        public BaseMainPage()
        {
            ToolbarItems.Add(new ToolbarItem("New...", null, () =>
            {
                FreshIOC.Container.Resolve<IFreshNavigationService>()
                    .PushPage(FreshPageModelResolver.ResolvePageModel<AddPageModel>(), null);
            }));

            ToolbarItems.Add(new ToolbarItem("Logout", null, () =>
            {
                // TODO Destroy session thingies here

                Application.Current.MainPage = FreshPageModelResolver.ResolvePageModel<LoginPageModel>();
            }));
        }
    }
}