using DigCheckPro.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
    }
}

