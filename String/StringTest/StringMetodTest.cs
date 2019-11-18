using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringTest
{
    [TestClass]
    public class StringMetodTest
    {
        [TestMethod]
        public void GetMaxNumberOfIdenticalConsecutiveNumbers_Test()
        {
            int expected = 0;

            string testString = "abcz";//case of string without numbers 
            int actual = TestString.Program.MaxAmountOfNumbers(testString);
            Assert.AreEqual(expected, actual);

            testString = "b";//case of string with one not numeric symbol 
            actual = TestString.Program.MaxAmountOfNumbers(testString);
            Assert.AreEqual(expected, actual);

            testString = " ";
            actual = TestString.Program.MaxAmountOfNumbers(testString);
            Assert.AreEqual(expected, actual);

            expected = 1;

            testString = "1";
            actual = TestString.Program.MaxAmountOfNumbers(testString);
            Assert.AreEqual(expected, actual);

            testString = "21";
            actual = TestString.Program.MaxAmountOfNumbers(testString);
            Assert.AreEqual(expected, actual);

            testString = "ad12d";
            actual = TestString.Program.MaxAmountOfNumbers(testString);
            Assert.AreEqual(expected, actual);

            expected = 2;

            testString = "ad22d";
            actual = TestString.Program.MaxAmountOfNumbers(testString);
            Assert.AreEqual(expected, actual);

            testString = "99";
            actual = TestString.Program.MaxAmountOfNumbers(testString);
            Assert.AreEqual(expected, actual);

        }
       
    }
}
