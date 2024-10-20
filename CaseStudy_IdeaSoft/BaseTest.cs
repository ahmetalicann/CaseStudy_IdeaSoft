using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaseStudy_IdeaSoft
{
    public class BaseTest
    {
        public IWebDriver driver;
        public WebDriverWait wait;


        [SetUp]
        public void tarayiciAc()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //Sayfanın yüklenmesi için(Tüm sayfa yüklenmeden işleme devam etmez)
            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(4);
            //Üzerinde işlem yapılacak element
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://testcase.myideasoft.com/");
        }

        [TearDown]
        public void tarayiciKapat()
        {
            driver.Quit();
        }



    }
}