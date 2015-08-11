using App1.PageModels;
using FreshMvvm;
using Xamarin.Forms;

namespace App1
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = FreshPageModelResolver.ResolvePageModel<LoginPageModel>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}