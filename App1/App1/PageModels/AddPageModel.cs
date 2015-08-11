using FreshMvvm;
using Xamarin.Forms;

namespace App1.PageModels
{
    public class AddPageModel : FreshBasePageModel
    {
        public Command AddFormCommand
        {
            get
            {
                return new Command(async () =>
               {
                   // Keep reference to main app navigation service
                   var nav = FreshIOC.Container.Resolve<IFreshNavigationService>();

                   var addIndicationFormPage = new FreshMasterDetailNavigationContainer();
                   addIndicationFormPage.Init("Menu");
                   addIndicationFormPage.AddPage<AddFormPageModel>("Tab 1");

                   await nav.PushPage(addIndicationFormPage, null);

                   // Restore main app navigation service
                   FreshIOC.Container.Register(nav);
               });
            }
        }
    }
}