using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Firefox;

namespace ExamPhilSpecs.Scripts
{
    [TestClass]
    public class SignIn
    {
        IWebDriver driver;
        [TestMethod]
        public void CreateNewUser()
        {
            var outPutDirectory = "Change here for the place where is the drivers folder, ex: C:\\Users\\....";            
            driver = new FirefoxDriver(outPutDirectory);

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");   
   
            driver.FindElement(By.XPath("//a[@class='login']")).Click();

            driver.FindElement(By.XPath("//input[@id='email_create']")).SendKeys("testessa_ba3@test.com");

            driver.FindElement(By.XPath("//form[@id='create-account_form']//span[1]")).Click();
                                 
            //driver.FindElement(By.XPath("//input[@id='id_gender1']")).Click();
            driver.FindElement(By.CssSelector("#id_gender1")).Click();

            //driver.FindElement(By.XPath("//input[@id='customer_firstname']")).SendKeys("Tester");
            driver.FindElement(By.CssSelector("#customer_firstname")).SendKeys("Tester");

            //driver.FindElement(By.XPath("//input[@id='customer_lastname']")).SendKeys("QACQ");
            driver.FindElement(By.CssSelector("#customer_lastname")).SendKeys("QACQ");

            //driver.FindElement(By.XPath("//input[@id='passwd']")).SendKeys("@teste1");
            driver.FindElement(By.CssSelector("#passwd")).SendKeys("@teste1");

            //IWebElement elem = driver.FindElement(By.CssSelector("#days"));
            //SelectElement select = new SelectElement(elem);
            //select.SelectByText("21");
            driver.FindElement(By.XPath("//select[@id='days']//option[contains(text(),'27')]")).Click();

            //IWebElement elem2 = driver.FindElement(By.CssSelector("#months"));
            //SelectElement select2 = new SelectElement(elem2);
            //select2.SelectByText("October");
            driver.FindElement(By.XPath("//option[contains(text(),'October')]")).Click();

            //IWebElement elem3 = driver.FindElement(By.CssSelector("#years"));
            //SelectElement select3 = new SelectElement(elem3);
            //select3.SelectByText("1975");
            driver.FindElement(By.XPath("//option[contains(text(),'1963')]")).Click();

            //driver.FindElement(By.XPath("//input[@id='company']")).SendKeys("Teste QA");
            driver.FindElement(By.CssSelector("#company")).SendKeys("Tsteste");

            //driver.FindElement(By.XPath("//input[@id='address1']")).SendKeys("Rua do QA");
            driver.FindElement(By.CssSelector("#address1")).SendKeys("Rua do QA");
            
            //City
            //driver.FindElement(By.XPath("//input[@id='city']")).SendKeys("Salvador");
            driver.FindElement(By.CssSelector("#city")).SendKeys("El Salvador");

            //State Select
            //IWebElement elemStat = driver.FindElement(By.CssSelector("#id_state"));
            //SelectElement selectStat = new SelectElement(elemStat);
            //selectStat.SelectByText("Louisiana");
            driver.FindElement(By.XPath("//option[contains(text(),'Louisiana')]")).Click();

            //Postal Code
            //driver.FindElement(By.XPath("//input[@id='postcode']")).SendKeys("83617");
            driver.FindElement(By.CssSelector("#postcode")).SendKeys("83617");

            //Mobile Phone
            //driver.FindElement(By.XPath("//input[@id='phone_mobile']")).SendKeys("5571991452325");
            driver.FindElement(By.CssSelector("#phone_mobile")).SendKeys("5571991452325");

            //Assign an address alias for future reference.
            //driver.FindElement(By.XPath("//input[@id='alias']")).SendKeys("Testando");
            driver.FindElement(By.CssSelector("#alias")).Clear();
            driver.FindElement(By.CssSelector("#alias")).SendKeys("Testando");

            //Register Button
            //driver.FindElement(By.XPath("//span[contains(text(),'Register')]")).Click();
            driver.FindElement(By.CssSelector("body.authentication.hide-left-column.hide-right-column.lang_en:nth-child(2) div.columns-container div.container div.row:nth-child(3) div.center_column.col-xs-12.col-sm-12 div:nth-child(1) form.std.box div.submit.clearfix:nth-child(4) button.btn.btn-default.button.button-medium:nth-child(4) > span:nth-child(1)")).Click(); ;






        }

    }
}
