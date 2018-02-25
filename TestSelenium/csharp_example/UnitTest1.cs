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

            // Открыть браузер с начальной страницей брокера
            driver.Navigate().GoToUrl("https://open-broker.ru/");
            driver.Manage().Window.Maximize();

            // Перейти в раздел Торговать
            driver.FindElement(By.XPath("//*[@id='app']/div/div/div[1]/div[1]/div/div/div[1]/div[1]/div[2]/a")).Click();

            // Заполнение лид формы внизу страницы

            //Имя (Клик и Заполнение)
            driver.FindElement(By.XPath("//*[@id='app']/div/div/div[3]/div[1]/div[6]/div/div/div/div[2]/div[2]/div[1]/div/input")).Click();
            driver.FindElement(By.XPath("//*[@id='app']/div/div/div[3]/div[1]/div[6]/div/div/div/div[2]/div[2]/div[1]/div/input")).SendKeys("Андрей");
            System.Threading.Thread.Sleep(1000);
            //Фамилия (Клик и Заполнение)
            driver.FindElement(By.XPath("//*[@id='app']/div/div/div[3]/div[1]/div[6]/div/div/div/div[2]/div[2]/div[2]/div/input")).Click();
            driver.FindElement(By.XPath("//*[@id='app']/div/div/div[3]/div[1]/div[6]/div/div/div/div[2]/div[2]/div[2]/div/input")).SendKeys("Пространствов");
            System.Threading.Thread.Sleep(1000);
            //Телефон (Клик и Заполнение)
            driver.FindElement(By.XPath("//*[@id='app']/div/div/div[3]/div[1]/div[6]/div/div/div/div[2]/div[3]/div[1]/div/input")).Click();
            driver.FindElement(By.XPath("//*[@id='app']/div/div/div[3]/div[1]/div[6]/div/div/div/div[2]/div[3]/div[1]/div/input")).SendKeys("9111111111");
            System.Threading.Thread.Sleep(1000);
            //Почта (Клик и Заполнение)
            driver.FindElement(By.XPath("//*[@id='app']/div/div/div[3]/div[1]/div[6]/div/div/div/div[2]/div[3]/div[2]/div/input")).Click();
            driver.FindElement(By.XPath("//*[@id='app']/div/div/div[3]/div[1]/div[6]/div/div/div/div[2]/div[3]/div[2]/div/input")).SendKeys("preload@mail.ru");
            System.Threading.Thread.Sleep(1000);
            //Город (Клик и Заполнение)
            driver.FindElement(By.XPath("//*[@id='app']/div/div/div[3]/div[1]/div[6]/div/div/div/div[2]/div[4]/div[1]/div/input")).Click();
            driver.FindElement(By.XPath("//*[@id='app']/div/div/div[3]/div[1]/div[6]/div/div/div/div[2]/div[4]/div[1]/div/input")).SendKeys("Мо");
            driver.FindElement(By.XPath("//*[@id='app']/div/div/div[3]/div[1]/div[6]/div/div/div/div[2]/div[4]/div[1]/div/div[2]/div/ul/li")).Click();
            System.Threading.Thread.Sleep(1000);
            //Выбор Темы консультации (Клик и Заполнение)
            driver.FindElement(By.XPath("//*[@id='app']/div/div/div[3]/div[1]/div[6]/div/div/div/div[2]/div[4]/div[2]/div")).Click();
            driver.FindElement(By.XPath("//*[@id='app']/div/div/div[3]/div[1]/div[6]/div/div/div/div[2]/div[4]/div[2]/div/div[2]/div/ul/li[5]")).Click();
            System.Threading.Thread.Sleep(1000);
            // Кнопка Далее
            driver.FindElement(By.XPath("//*[@id='app']/div/div/div[3]/div[1]/div[6]/div/div/div/div[2]/div[6]/div/button")).Click();

            // driver.FindElement(By.XPath(""));

            System.Threading.Thread.Sleep(5000);

        }

        [TearDown]
        public void stop()
        {
            driver.Quit();
            driver = null;
        }

    }
}