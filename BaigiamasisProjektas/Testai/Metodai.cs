using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace AutoPaskaitos.BaigiamasisProjektas.Testai
{
    class Metodai
    {
        private IWebDriver driver;

        public void  PriesKiekvienaTestaHuman()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://humanitas.lt/";
        }

        public void PriesKiekvienaTestaKika()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://www.kika.lt";
        }

        public void priesKiekvienaTestaKaunas()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "http://www.kaunas.lt/";
        }


        public void Bumblauskas()
        {

            driver.FindElement(By.CssSelector(".isbn-search > input")).Click();
            driver.FindElement(By.CssSelector(".isbn-search > input")).SendKeys("Bumblauskas");
            driver.FindElement(By.CssSelector(".isbn-search > input")).SendKeys(Keys.Enter);
            driver.FindElement(By.CssSelector(".book-205946")).Click();

            Assert.AreEqual("https://humanitas.lt/lietuvos-istorija-kiekvienam.html", driver.Url);


        }

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

        public void PrisijungimoTestas()
        {

            driver.FindElement(By.CssSelector("#profile_menu > a")).Click();
            driver.FindElement(By.XPath("//form[@id='login_form']/div/input")).Click();
            driver.FindElement(By.XPath("//form[@id='login_form']/div/input")).SendKeys("vytenis_kriauciunas@yahoo.com");
            driver.FindElement(By.XPath("//form[@id='login_form']/div[2]/input")).Click();
            driver.FindElement(By.XPath("//form[@id='login_form']/div[2]/input")).SendKeys("2020KCS2020");
            driver.FindElement(By.XPath("//form[@id='login_form']/div[3]/button")).Click();

        }

        public void Paieska()
        {

            driver.FindElement(By.XPath("//a[@id='quick_search_show']/i")).Click();
            driver.FindElement(By.XPath("//div[@id='quick_search']/form/div/input")).SendKeys("Kačių žaislai");
            driver.FindElement(By.XPath("//div[@id='quick_search']/form/div/input")).SendKeys(Keys.Enter);
        }

        public void ArEsuTinkamamePuslapyje()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'Naujienos')]")).Click();
            driver.FindElement(By.XPath("//div[@id='context_menu']/div/ul/li[3]/a")).Click();
            driver.FindElement(By.XPath("//div[@id='news_listing']/div[3]/div[3]/a/img")).Click();


            Assert.AreEqual("https://www.kika.lt/blogas/kika-naujienos/naujiena-express-uzsakymu-linija/", driver.Url);
        }

        public void kirpyklos()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'Kirpyklos')]")).Click();
            driver.FindElement(By.CssSelector(".container-fluid > .close")).Click();
            driver.FindElement(By.CssSelector(".filter-option")).Click();
            driver.FindElement(By.CssSelector("li:nth-child(3) .text")).Click();
            driver.FindElement(By.CssSelector(".barber_div:nth-child(2) > .barber:nth-child(4) .col-xs-12:nth-child(2) a")).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 100)");
        }
        public void poKiekvienoTesto()
        {
            driver.Quit();
        }
    }


}


