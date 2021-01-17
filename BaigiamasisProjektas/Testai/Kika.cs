using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutoPaskaitos.BaigiamasisProjektas.Testai
{
    class Kika
    {
        private IWebDriver driver;

        [SetUp]
        public void priesKiekvienaTesta()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://www.kika.lt";
        }
        [Test]
        public void PrisijungimoTestas()
        {

            driver.FindElement(By.CssSelector("#profile_menu > a")).Click();
            driver.FindElement(By.XPath("//form[@id='login_form']/div/input")).Click();
            driver.FindElement(By.XPath("//form[@id='login_form']/div/input")).SendKeys("vytenis_kriauciunas@yahoo.com");
            driver.FindElement(By.XPath("//form[@id='login_form']/div[2]/input")).Click();
            driver.FindElement(By.XPath("//form[@id='login_form']/div[2]/input")).SendKeys("2020KCS2020");
            driver.FindElement(By.XPath("//form[@id='login_form']/div[3]/button")).Click();

        }

        [Test]
        public void Paieska()
        {

            driver.FindElement(By.XPath("//a[@id='quick_search_show']/i")).Click();
            driver.FindElement(By.XPath("//div[@id='quick_search']/form/div/input")).SendKeys("Kačių žaislai");
            driver.FindElement(By.XPath("//div[@id='quick_search']/form/div/input")).SendKeys(Keys.Enter);
        }
            [Test]
        public void ArEsuTinkamamePuslapyje()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'Naujienos')]")).Click();
            driver.FindElement(By.XPath("//div[@id='context_menu']/div/ul/li[3]/a")).Click();
            driver.FindElement(By.XPath("//div[@id='news_listing']/div[3]/div[3]/a/img")).Click();


            Assert.AreEqual("https://www.kika.lt/blogas/kika-naujienos/naujiena-express-uzsakymu-linija/", driver.Url);
        }

        [Test]

        public void kirpyklos()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'Kirpyklos')]")).Click();
            driver.FindElement(By.CssSelector(".container-fluid > .close")).Click();
            driver.FindElement(By.CssSelector(".filter-option")).Click();
            driver.FindElement(By.CssSelector("li:nth-child(3) .text")).Click();
            driver.FindElement(By.CssSelector(".barber_div:nth-child(2) > .barber:nth-child(4) .col-xs-12:nth-child(2) a")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 100)");
        }

        [TearDown]
        public void poKiekvienoTesto()
        {
           driver.Quit();
        }
    }
}