using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TransliteTests
{
    [TestClass]
    public class SwitchToCurrentTests
    {
        [TestMethod]
        public void SwitchToCurrent_Test()
        {
            string expected = "invalid symbol";

            string testString = "abcz";
            string actual = Translite.Translite.SwitchToCurrent(testString);
            Assert.AreEqual(expected, actual);

            testString = "12";
            actual = Translite.Translite.SwitchToCurrent(testString);
            Assert.AreEqual(expected, actual);

            testString = " ";
            actual = Translite.Translite.SwitchToCurrent(testString);
            Assert.AreEqual(expected, actual);

            testString = "ФЫRE";
            actual = Translite.Translite.SwitchToCurrent(testString);
            Assert.AreEqual(expected, actual);

            expected = "invalid latin symbol";

            testString = "FAQ";
            actual = Translite.Translite.SwitchToCurrent(testString);
            Assert.AreEqual(expected, actual);

            expected = "TSARSTVO";

            testString = "ЦАРСТВО";
            actual = Translite.Translite.SwitchToCurrent(testString);
            Assert.AreEqual(expected, actual);

            expected = "ЦАРСТВО";

            testString = "TSARSTVO";
            actual = Translite.Translite.SwitchToCurrent(testString);
            Assert.AreEqual(expected, actual);





        }
    }
}
