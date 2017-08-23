using SettingsSample.Helpers;
using System;
using Xamarin.Forms;

namespace SettingsSample
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			UpdateSettingsButton.Clicked += UpdateSettingsButton_Clicked;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			GetSettings();
		}

		private void GetSettings()
		{
			NameLabel.Text = "Current Value of Name (Settings) : " + Settings.Name;
		}

		private void UpdateSettingsButton_Clicked(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(NameEntry.Text))
			{
				Settings.Name = NameEntry.Text;
				GetSettings();
			}
			else
				DisplayAlert("Name Settings", "Enter enter valid value", "ok");
		}
	}
}
