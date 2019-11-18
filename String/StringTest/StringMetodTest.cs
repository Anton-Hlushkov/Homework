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



        }
    }
}
