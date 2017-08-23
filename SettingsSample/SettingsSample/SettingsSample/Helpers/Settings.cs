// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace SettingsSample.Helpers
{
	/// <summary>
	/// This is the Settings static class that can be used in your Core solution or in any
	/// of your client applications. All settings are laid out the same exact way with getters
	/// and setters. 
	/// </summary>
	public static class Settings
	{
		private static ISettings AppSettings
		{
			get
			{
				return CrossSettings.Current;
			}
		}

		#region Setting Constants

		//Our string Setting
		private const string NameKey = "name_key";
		private static readonly string NameDefault = string.Empty;
		
		#endregion

		//Our Settings Property
		public static string Name
		{
			get
			{
				return AppSettings.GetValueOrDefault(NameKey, NameDefault);
			}
			set
			{
				AppSettings.AddOrUpdateValue(NameKey, value);
			}
		}

		

	}
}