using App1.MvvmContainers;
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
                   var addIndicationFormPage = new MasterDetailNavigationContainer();
                   addIndicationFormPage.Init("Menu");
                   addIndicationFormPage.AddPage<AddFormPageModel>("Tab 1");

                   await FreshIOC.Container.Resolve<IFreshNavigationService>().PushPage(addIndicationFormPage, null);
               });
            }
        }
    }
}