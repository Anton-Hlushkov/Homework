using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
namespace SeleniumMailRuTest
{
    class PageMail
    {
        IWebDriver browser = new ChromeDriver();
        public void Login()
        {

            browser.Navigate().GoToUrl("https://mail.ru");

            IWebElement login = GetElement(By.Id("mailbox:login"), browser);
            login.SendKeys("vasya_vasyapupkin1994_pupkin" + Keys.Enter);

            IWebElement password = GetElement(By.Id("mailbox:password"), browser);
            password.SendKeys("gachihyper1994" + Keys.Enter);

        }
       

        public void ReadMessage()
        {
            IWebElement messageUnread = GetElement(By.XPath("//span[@title='Вася Пупкин <vasyly.vasylevich.pupkin.1994@gmail.com>']"), browser);
            messageUnread.Click();
        }

        public void Quit()
        {
            browser.Quit();
        }


        private IWebElement GetElement(By elementLocator, IWebDriver driver)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(elementLocator));
        }
    }
}
