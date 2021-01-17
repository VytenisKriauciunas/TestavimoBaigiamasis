using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace AutoPaskaitos.BaigiamasisProjektas.Testai
{
    class MetodaiKaunas
    {
        private IWebDriver driver;

        public void priesKiekvienaTestaKaunas()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "http://www.kaunas.lt/";
        }


        public void Turizmopuslapis()
        {
            driver.FindElement(By.CssSelector("#menu-item-116670 > a")).Click();
            driver.FindElement(By.CssSelector("#menu-item-397 > a")).Click();
            driver.FindElement(By.CssSelector("#menu-item-396 > a")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            Assert.AreEqual("https://visit.kaunas.lt/en/", driver.Url);
        }

        public void Sabonis()
        {
            driver.FindElement(By.CssSelector("#menu-item-45 > .dropdown-toggle")).Click();
            driver.FindElement(By.CssSelector("#menu-item-51 > a")).Click();
            driver.FindElement(By.CssSelector("#menu-item-541 > a")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Miesto Garbės piliečiai')]")).Click();
            driver.FindElement(By.CssSelector("tr:nth-child(6) > td:nth-child(2) .fa")).Click();

        }

        public void FormosUzsakymas()
        {
            driver.FindElement(By.CssSelector("#menu-item-41 > .dropdown-toggle")).Click();
            driver.FindElement(By.CssSelector("#menu-item-529 > a")).Click();
            driver.FindElement(By.CssSelector(".inner > ul > li:nth-child(3) > a")).Click();
            driver.FindElement(By.CssSelector("#collapseCat_63 .btn")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.XPath("//div[@id='p_p_id_101_INSTANCE_jTv8_']/div/div/table/tbody/tr[3]/td/a")).Click();
            driver.FindElement(By.CssSelector(".document-icon")).Click();

        }

        public void poKiekvienoTesto()
        {
            driver.Quit();
        }
    }


}