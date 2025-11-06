using System;

namespace Integrations.Localization.Resources
{
    public static  class Localization
    {
        /// <summary>
        /// Select localization resource
        /// </summary>
        /// <param name="cultureCode">fi-FI or sv-SE</param>
        /// <returns></returns>
        public static System.Globalization.CultureInfo SetLocalization(string cultureCode)
        {
            var culture = new System.Globalization.CultureInfo(cultureCode);

            localization.Properties.Resources.Culture = culture;

            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = culture;

            return culture;
        }

        /// <summary>
        /// Get translation of the text
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Localize(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return null;

            string translation = localization.Properties.Resources.ResourceManager.GetString(text, localization.Properties.Resources.Culture) ??
                $"DEFINE TEXT FOR '{text}'";

            return translation;
        }
    }
}
