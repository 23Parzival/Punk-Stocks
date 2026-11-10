using Punk_Stocks.Models.Enums;
using System;
using System.Globalization;

namespace Punk_Stocks.Services
{
    internal static class LanguageManager
    {
        private static CultureInfo culture = CultureInfo.GetCultureInfo("en");

        public static AppLanguage Current { get; private set; } = AppLanguage.English;
        public static event EventHandler LanguageChanged;

        public static void SetLanguage(AppLanguage language)
        {
            Current = language;
            culture = CultureInfo.GetCultureInfo(language == AppLanguage.French ? "fr" : "en");

            LanguageChanged?.Invoke(null, EventArgs.Empty);
        }

        public static string Get(string key)
        {
            return Properties.Resources.ResourceManager.GetString(key, culture) ?? key;
        }

        public static string Format(string key, params object[] args)
        {
            return string.Format(Get(key), args);
        }
    }
}
