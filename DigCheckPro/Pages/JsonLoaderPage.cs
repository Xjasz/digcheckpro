using Xamarin.Forms;
using System.Reflection;
using System.IO;
using Newtonsoft.Json;

namespace DigCheckPro.Pages
{
    public class JsonLoaderPage : ContentPage
	{
		public JsonLoaderPage()
		{
			var assembly = IntrospectionExtensions.GetTypeInfo(typeof(TextLoaderPage)).Assembly;

			Stream stream = assembly.GetManifestResourceStream("DigCheckPro.Resources.DigCheckProJsonResource.json");

			Earthquake[] earthquakes;


			using (var reader = new StreamReader(stream))
			{

				var json = reader.ReadToEnd();
				var rootobject = JsonConvert.DeserializeObject<Rootobject>(json);

				earthquakes = rootobject.earthquakes;
			}

			var listView = new ListView();
			listView.ItemsSource = earthquakes;


			Content = new StackLayout
			{
				Padding = new Thickness(0, 20, 0, 0),
				VerticalOptions = LayoutOptions.StartAndExpand,
				Children = {
					new Label { Text = "Embedded Resource JSON File (DigCheckPro)",
						FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
						FontAttributes = FontAttributes.Bold
					}, listView
				}
			};

		}
	}
}

