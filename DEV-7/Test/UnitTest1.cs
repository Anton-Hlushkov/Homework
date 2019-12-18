using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorTest;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        const string urlCalkulyatorRu = "http://calkulyator.ru/";
        IWebDriver webDriver = new ChromeDriver();
        CalculatorPage calkulyatorRuPage;
        TestInvoker testInvoker;
        [TestInitialize]
        public void Setup()
        {
            webDriver.Navigate().GoToUrl(urlCalkulyatorRu);
            calkulyatorRuPage = new CalculatorPage(webDriver);
            calkulyatorRuPage.PageInit();
            testInvoker = new TestInvoker(calkulyatorRuPage);

        }
       [TestMethod]
        [DataRow("2+2=", "4")]
        [DataRow("5+10=", "15")]
        [DataRow("1000+1325=", "2325")]
        
        public void AdditionIntegerNumbersTest_DisplaysCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = testInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }
        [DataRow("2.5+2.5=", "5")]
        [DataRow("0.1+4.6=", "4.7")]
        [DataRow("1.225+3.111=", "4.336")]
        
        public void AdditionFractionalNumbersTest_DisplaysCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = testInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }
        [DataRow("2.5-2.5=", "0")]
        [DataRow("0.1-4.6=", "-4.5")]
        [DataRow("1.225-3.111=", "-1.886")]

        public void SubtractionnFractionalNumbersTest_DisplaysCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = testInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }
        [DataRow("0√=", "0")]
        [DataRow("25√=", "5")]
        [DataRow("13√=", "3.605551275464")]

        public void SquareNumbersTest_DisplaysCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = testInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }
    }
}
