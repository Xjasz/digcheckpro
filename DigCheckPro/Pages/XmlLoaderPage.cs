using Xamarin.Forms;
using System.Reflection;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace DigCheckPro.Pages
{
    public class XmlLoaderPage : ContentPage
	{
		public XmlLoaderPage ()
		{
			var assembly = IntrospectionExtensions.GetTypeInfo(typeof(TextLoaderPage)).Assembly;
			Stream stream = assembly.GetManifestResourceStream("DigCheckPro.Resources.DigCheckProXmlResource.xml");

			List<Monkey> monkeys;
			using (var reader = new StreamReader(stream)) {
				var serializer = new XmlSerializer(typeof(List<Monkey>));
				monkeys = (List<Monkey>)serializer.Deserialize(reader);
			}

			var listView = new ListView ();
			listView.ItemsSource = monkeys;


			Content = new StackLayout {
				Padding = new Thickness (0, 20, 0, 0),
				VerticalOptions = LayoutOptions.StartAndExpand,
				Children = {
					new Label { Text = "Embedded Resource XML File (DigCheckPro)", 
						FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
						FontAttributes = FontAttributes.Bold
					}, listView
				}
			};

		}
	}
}

