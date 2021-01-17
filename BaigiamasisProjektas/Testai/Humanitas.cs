using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;


namespace AutoPaskaitos.BaigiamasisProjektas.Testai
{
    class Humanitas
    {
        private IWebDriver driver;

        [SetUp]
        public void priesKiekvienaTesta()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://humanitas.lt/";
        }

        [Test]
        public void Bumblauskas()
        {

            driver.FindElement(By.CssSelector(".isbn-search > input")).Click();
            driver.FindElement(By.CssSelector(".isbn-search > input")).SendKeys("Bumblauskas");
            driver.FindElement(By.CssSelector(".isbn-search > input")).SendKeys(Keys.Enter);
            driver.FindElement(By.CssSelector(".book-205946")).Click();

            Assert.AreEqual("https://humanitas.lt/lietuvos-istorija-kiekvienam.html", driver.Url);


        }
        [Test]
        public void PrisijungimasIrKrepselis()
        {

            driver.FindElement(By.CssSelector("#login span")).Click();
            driver.FindElement(By.CssSelector(".log_text_input:nth-child(3) > input")).Click();
            driver.FindElement(By.CssSelector(".log_text_input:nth-child(3) > input")).SendKeys("vytenis_kriauciunas@yahoo.com");
            driver.FindElement(By.CssSelector(".log_text_input:nth-child(5) > input")).Click();
            driver.FindElement(By.CssSelector(".log_text_input:nth-child(5) > input")).SendKeys("2020KCS2020");
            driver.FindElement(By.CssSelector(".log_submit_input > input")).Click();
            driver.FindElement(By.CssSelector(".closenaujien")).Click();

            driver.FindElement(By.CssSelector(".isbn-search > input")).Click();
            driver.FindElement(By.CssSelector(".isbn-search > input")).SendKeys("Maus");
            driver.FindElement(By.CssSelector(".isbn-search > input")).SendKeys(Keys.Enter);
            driver.FindElement(By.CssSelector(".book-143872")).Click();
            driver.FindElement(By.CssSelector("#to_cart")).Click();
            driver.FindElement(By.CssSelector(".isbn-search > input")).Click();
            driver.FindElement(By.CssSelector(".isbn-search > input")).SendKeys("Obama");
            driver.FindElement(By.CssSelector(".isbn-search > input")).SendKeys(Keys.Enter);
            driver.FindElement(By.CssSelector(".book-218881")).Click(); // Del kazkokiu priezasciu kartais skipina sia eilute ir uzlusta
            driver.FindElement(By.CssSelector("#to_cart")).Click();
            driver.FindElement(By.CssSelector(".cart-start > .row_to_cart")).Click();
            driver.FindElement(By.CssSelector(".dlv-3 > .r")).Click();
            driver.FindElement(By.CssSelector(".confirm_rules > input")).Click();
            driver.FindElement(By.CssSelector(".step_fw > input")).Click();

        }


        [TearDown]
        public void poKiekvienoTesto()
        {
           driver.Quit();
        }
    }
}
