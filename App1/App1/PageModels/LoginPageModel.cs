using FreshMvvm;
using PropertyChanged;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.PageModels
{
    [ImplementPropertyChanged]
    public class LoginPageModel : FreshBasePageModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public ICommand Login
        {
            get
            {
                return new Command(() =>
                {
                    // TODO real login logic here

                    var mainPage = new FreshTabbedNavigationContainer();
                    mainPage.AddTab<DashboardPageModel>("Dashboard", null);
                    mainPage.AddTab<OtherPageModel>("Other", null);

                    Application.Current.MainPage = mainPage;
                });
            }
        }
    }
}