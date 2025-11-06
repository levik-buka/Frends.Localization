using Integrations.Localization.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Integrations.Localization.Tasks
{
    /// <summary>
    /// Tasks for localization test and debuging purposes
    /// </summary>
    public class LocalizationTasks
    {
        /// <summary>
        /// Returns predefined text on Finnish or Swedish
        /// </summary>
        /// <param name="cultureCode">fi_FI or sv_SE</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string LocalizeText(string cultureCode) 
        {
            if (cultureCode == null) throw new ArgumentNullException(nameof(cultureCode));

            Resources.Localization.SetLocalization(cultureCode);

            var text = "test";
            var translatedText = text.Localize();

            return translatedText;
        }
    }
}
