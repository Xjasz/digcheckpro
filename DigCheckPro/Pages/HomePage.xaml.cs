using System;
using Xamarin.Forms;

namespace DigCheckPro.Pages
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
            InitializeComponent();
        }

        async void OnContinueButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListingsPage());
        }
    }
}