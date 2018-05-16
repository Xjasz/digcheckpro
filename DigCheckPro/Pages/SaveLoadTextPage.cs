using Xamarin.Forms;

namespace DigCheckPro.Pages
{
    public class SaveLoadTextPage : ContentPage
	{
		const string fileName = "temp.txt";
		Button loadButton, saveButton;

		public SaveLoadTextPage()
		{
			var fileService = DependencyService.Get<ISaveAndLoad> ();

			var input = new Entry { Text = "" };
			var output = new Label { Text = "" };
			saveButton = new Button {Text = "Save"};

			saveButton.Clicked += async (sender, e) => {
				loadButton.IsEnabled = saveButton.IsEnabled = false;
				// uses the Interface defined in this project, and the implementations that must
				// be written in the iOS, Android and UWP app projects to do the actual file manipulation

				await fileService.SaveTextAsync (fileName, input.Text);
				loadButton.IsEnabled = saveButton.IsEnabled = true;
			};

			loadButton = new Button {Text = "Load"};
			loadButton.Clicked += async (sender, e) => {
				loadButton.IsEnabled = saveButton.IsEnabled = false;

				// uses the Interface defined in this project, and the implementations that must
				// be written in the iOS, Android and UWP app projects to do the actual file manipulation
				output.Text = await fileService.LoadTextAsync(fileName);
				loadButton.IsEnabled = saveButton.IsEnabled = true;
			};
			loadButton.IsEnabled = fileService.FileExists (fileName);

			var buttonLayout = new StackLayout {
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				Children = { saveButton, loadButton }
			};

			Content = new StackLayout {
				Padding = new Thickness (0, 20, 0, 0),
				VerticalOptions = LayoutOptions.StartAndExpand,
				Children = {
					new Label {
						Text = "Save and Load Text (PCL)",
						FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
						FontAttributes = FontAttributes.Bold
					},
					new Label { Text = "Type below and press Save, then Load" },
					input,
					buttonLayout,
					output
				}
			};
		}
	}
}