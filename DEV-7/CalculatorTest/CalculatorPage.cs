using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
namespace CalculatorTest
{
    public class CalculatorPage : PageObject
    {
         
        readonly Dictionary<string, By> locators = new Dictionary<string, By>
        {
            { "0", By.XPath("//*[@id='nmr_25']/table/tbody/tr/td") },
            { "00", By.XPath("//td[text()='00']") },
            { ".", By.XPath("//td[text()='.']") },
            { "1", By.XPath("//td[text()='1']") },
            { "2", By.XPath("//td[text()='2']") },
            { "3", By.XPath("//td[text()='3']") },
            { "4", By.XPath("//td[text()='4']") },
            { "5", By.XPath("//td[text()='5']") },
            { "6", By.XPath("//td[text()='6']") },
            { "7", By.XPath("//td[text()='7']") },
            { "8", By.XPath("//td[text()='8']") },
            { "9", By.XPath("//td[text()='9']") },
            { "+", By.XPath("//td[text()='+']") },
            { "=", By.XPath("//td[text()='=']") },
            { "*", By.XPath("//*[@id='nmr_16']/table/tbody/tr/td") },
            { "-", By.XPath("//td[text()='-']") },
            { "/", By.XPath("//td[text()='÷']") },
            { "^", By.XPath("//sup[text()='ʸ']") },
            { "√", By.XPath("//td[text()='√']") },
            { "M-", By.XPath("//td[text()='M-']") },
            { "M+", By.XPath("//td[text()='M+']") },
            { "MR", By.XPath("//td[text()='MR']") },
            { "MC", By.XPath("//td[text()='MC']") },
            { "DEL", By.XPath("//td[text()='00￫0']") },
            { "(-)", By.XPath("//td[text()='+/-']") },
            { "AC", By.XPath("//td[text()='AC']") },
            { "C", By.XPath("//td[text()='C']") },
            { "Display", By.Id("display") }
        };
        public Dictionary<string, IWebElement> WebElements { get; set; } = new Dictionary<string, IWebElement>();
        public void PageInit()
        {
            foreach (KeyValuePair<string, By> locator in locators)
            {
                WebElements.Add(locator.Key, GetIWebElement(locator.Value));
            }
        }
        public CalculatorPage(IWebDriver driver) : base(driver)
        {

        }
    }
        

    
}
