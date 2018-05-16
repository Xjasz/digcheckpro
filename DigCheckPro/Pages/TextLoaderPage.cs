using Xamarin.Forms;
using System.Reflection;
using System.IO;

namespace DigCheckPro.Pages
{
    public class TextLoaderPage : ContentPage 
	{
		public TextLoaderPage ()
		{
			var editor = new Label { Text = "loading...", HeightRequest = 300};
            
			var assembly = IntrospectionExtensions.GetTypeInfo(typeof(TextLoaderPage)).Assembly;
			Stream stream = assembly.GetManifestResourceStream("DigCheckPro.Resources.DigCheckProTextResource.txt");

			string text = "";
			using (var reader = new StreamReader(stream)) {
				text = reader.ReadToEnd ();
			}

			editor.Text = text;

			Content = new StackLayout {
				Padding = new Thickness (0, 20, 0, 0),
				VerticalOptions = LayoutOptions.StartAndExpand,
				Children = {
					new Label { Text = "Embedded Resource Text File (DigCheckPro)", 
						FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
						FontAttributes = FontAttributes.Bold
					}, editor
				}
			};

		}
	}
}

