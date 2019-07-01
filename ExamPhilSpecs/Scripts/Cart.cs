using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ExamPhilSpecs.Scripts
{
    [TestClass]
    public class Cart
    {
        IWebDriver driver;
        [TestMethod]
        public void AddProduct()
        {
            var outPutDirectory = "Change here for the place where is the drivers folder, ex: C:\\Users\\....";
            driver = new ChromeDriver(outPutDirectory);


            driver.Navigate().GoToUrl("http://automationpractice.com");
                        
            driver.FindElement(By.CssSelector("body.index.hide-left-column.hide-right-column.lang_en:nth-child(2) div.columns-container div.container div.row:nth-child(2) div.center_column.col-xs-12.col-sm-12 div.tab-content ul.product_list.grid.row.homefeatured.tab-pane.active:nth-child(1) li.ajax_block_product.col-xs-12.col-sm-4.col-md-3.last-item-of-mobile-line:nth-child(2) div.product-container div.right-block div.button-container:nth-child(4) a.button.ajax_add_to_cart_button.btn.btn-default:nth-child(1) > span:nth-child(1)")).Click();

            // Testing if the Button "Proceed to checkout" is enabled
            Assert.IsTrue(driver.FindElement(By.CssSelector("body.index.hide-left-column.hide-right-column.lang_en:nth-child(2) div.header-container div.container div.row div.clearfix div.layer_cart_cart.col-xs-12.col-md-6 div.button-container:nth-child(5) a.btn.btn-default.button.button-medium > span:nth-child(1)")).Enabled);

        }
    }
}
