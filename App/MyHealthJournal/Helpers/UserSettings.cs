using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace MyHealthJournal.Helpers
{
    /// <summary>
    /// User settings 
    /// </summary>
    public class UserSettings : IUserSettings
	{
		private static ISettings Settings
		{
			get
			{
				return CrossSettings.Current;
			}
		}

        

		private const string AnySettingKey = "ANY_SETTING_KEY";

		public string GetAnySetting()
		{
		    return Settings.GetValueOrDefault(AnySettingKey, string.Empty);
		}

        public void SaveAnySetting(string value)
		{
			Settings.AddOrUpdateValue(AnySettingKey, value);
		}

	}
}