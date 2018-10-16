using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrmDigitalCard.Xamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            var browser = new WebView();
            browser.Source = "https://mockupstock.poweraddon.com";
            Content = browser;
        }
    }
}
