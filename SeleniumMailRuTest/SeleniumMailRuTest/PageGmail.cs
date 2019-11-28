using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
namespace SeleniumMailRuTest
{
    class PageGmail
    {
        IWebDriver browser = new ChromeDriver();
        public void Login()
        {

            browser.Navigate().GoToUrl("https://accounts.google.com/signin/v2/identifier?service=mail&passive=true&rm=false&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&ss=1&scc=1&ltmpl=default&ltmplcache=2&emr=1&osid=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin");

            IWebElement login = GetElement(By.Id("identifierId"), browser);
            login.SendKeys("vasyly.vasylevich.pupkin.1994" + Keys.Enter);

            IWebElement password = GetElement(By.Name("password"), browser);
            password.SendKeys("gachihyper1994" + Keys.Enter);

        }

        public void SendMessage()
        {
            IWebElement buttonWrite = GetElement(By.XPath("//div[@class='T-I J-J5-Ji T-I-KE L3']"), browser);
            buttonWrite.Click();

            IWebElement mail = GetElement(By.ClassName("vO"), browser);
            mail.SendKeys("vasya_vasyapupkin1994_pupkin@mail.ru");

            IWebElement topic = browser.FindElement(By.Id(":8u"));
            topic.SendKeys("Test");

            IWebElement message = browser.FindElement(By.Id(":9z"));
            message.SendKeys(DateTime.Now.ToString());

            IWebElement buttonSendMessage = browser.FindElement(By.Id(":8k"));
            buttonSendMessage.Click();
        }
        public void Quit()
        {
            browser.Quit();
        }

        private IWebElement GetElement(By elementLocator, IWebDriver driver)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(15)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(elementLocator));
        }
    }
}
