using Xamarin.Forms;

namespace DigCheckPro.Pages
{
    public class ListingsPage : TabbedPage
	{
		public ListingsPage()
		{
            Children.Add(new TextLoaderPage { Title = "TXT Resource", Icon = "txt.png" });

            Children.Add(new XmlLoaderPage { Title = "XML Resource", Icon = "xml.png" });

            Children.Add(new JsonLoaderPage { Title = "JSON Resource", Icon = "json.png" });

            Children.Add(new SaveLoadTextPage { Title = "Save/Load", Icon = "saveload.png" });
        }
	}
}

