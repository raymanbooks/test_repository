using System;
using System.Drawing;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;




namespace csharp_example
{
    [TestFixture]
    public class MyFirstTest
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void start()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [Test]
        public void FirstTest()
        {
            driver.Navigate().GoToUrl("https://open-broker.ru/");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://open-broker.ru/trading/");
            driver.FindElement(By.XPath("//*[@id='app']/div/div/div[3]/div[1]/div[6]/div/div/div/div[2]/div[2]/div[1]/div/input")).Click();
            driver.FindElement(By.XPath("//*[@id='app']/div/div/div[3]/div[1]/div[6]/div/div/div/div[2]/div[2]/div[1]/div/input")).SendKeys("Андрей");
            System.Threading.Thread.Sleep(2000);
           //driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
           // wait.Until(ExpectedConditions.TitleIs("webdriver - Поиск в Google"));
            System.Threading.Thread.Sleep(2000);
        }

        [TearDown]
        public void stop()
        {
            driver.Quit();
            driver = null;
        }

    }
}