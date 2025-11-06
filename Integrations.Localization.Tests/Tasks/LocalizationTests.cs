using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integrations.Localization;

namespace Integrations.Localization.Tests.Tasks
{
    [TestClass]
    public class LocalizationTests
    {
        [TestMethod]
        public void TestLocalizationFi()
        {
            var culture = "fi-FI";
            var result = Localization.Tasks.LocalizationTasks.LocalizeText(culture);

            var expectedResult = "suomenkielinen";
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestLocalizationSE()
        {
            var culture = "sv-SE";
            var result = Localization.Tasks.LocalizationTasks.LocalizeText(culture);

            var expectedResult = "svenskatalande";
            Assert.AreEqual(expectedResult, result);
        }
    }
}
