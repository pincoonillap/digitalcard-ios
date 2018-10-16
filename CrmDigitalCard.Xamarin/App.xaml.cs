using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CrmDigitalCard.Xamarin
{
    public partial class App : Application
    {
        public App()
        {
            var tabs = new TabbedPage();

            //tabs.Children.Add(new LocalHtml { Title = "Local" });
            //tabs.Children.Add(new LocalHtmlBaseUrl { Title = "BaseUrl" });
            tabs.Children.Add(new MainPage { Title = "Web Page" });
            //tabs.Children.Add(new WebAppPage { Title = "External" });

            MainPage = tabs;
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
