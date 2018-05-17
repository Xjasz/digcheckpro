using DigCheckPro.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace DigCheckPro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class App : Application
	{
		public App ()
		{
            var homePage = new NavigationPage(new HomePage()) { Title = "Home Page" };

            MainPage = homePage;
        }

        protected override void OnStart()
        {
            base.OnStart();
            AppCenter.Start("android=b531b684-e9d2-415d-8cdc-608de4f99893;", typeof(Analytics), typeof(Crashes));
        }
    }
}