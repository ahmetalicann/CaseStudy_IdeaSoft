using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaseStudy_IdeaSoft;
using OpenQA.Selenium.Support.UI;

namespace CaseStudy_IdeaSoft
{
    public class HomeClass : BaseTest
    {

        //FIND Methotları
        public IWebElement findId(string elementId)
        {
            IWebElement element = driver.FindElement(By.Id(elementId));
            return element;
        }

        public IWebElement findCSS(string elementCss)
        {
            IWebElement element = driver.FindElement(By.CssSelector(elementCss));
            return element;
        }

        public IWebElement findXpath(string elementXpath)
        {
            IWebElement element = driver.FindElement(By.XPath(elementXpath));
            return element;
        }

        public IWebElement findName(string elementName)
        {
            IWebElement element = driver.FindElement(By.Name(elementName));
            return element;
        }

        public IWebElement findClass(string elementClass)
        {
            IWebElement element = driver.FindElement(By.ClassName(elementClass));
            return element;
        }

        //SEND Methotları

        public IWebElement sendId(string elementId, string sendText)
        {
            IWebElement element = driver.FindElement(By.Id(elementId));
            element.SendKeys(sendText);
            return element;
        }

        public IWebElement sendCSS(string elementCss, string sendText)
        {
            IWebElement element = driver.FindElement(By.CssSelector(elementCss));
            element.SendKeys(sendText);
            return element;
        }


        public IWebElement sendXpath(string elementXpath, string sendText)
        {
            IWebElement element = driver.FindElement(By.XPath(elementXpath));
            element.SendKeys(sendText);
            return element;
        }


        public IWebElement sendName(string elementName, string sendText)
        {
            IWebElement element = driver.FindElement(By.Name(elementName));
            element.SendKeys(sendText);
            return element;
        }


        public IWebElement sendClass(string elementClass, string sendText)
        {
            IWebElement element = driver.FindElement(By.Name(elementClass));
            element.SendKeys(sendText);
            return element;
        }

        //WAIT methotları
        //CSS ile seçilen elementin sayfada görünür olmasını bekler
        public void waitCssElement(string elementCss)
        {
            //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(elementCss)));
        }

        //Id ile seçilen elementin sayfada görünür olmasını bekler
        public void waitIdElement(string elementId)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id(elementId)));
        }

        //Xpath ile seçilen elementin sayfada görünür olmasını bekler
        public void waitXpathElement(string elementxPath)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(elementxPath)));
        }

        //Class ile seçilen elementin sayfada görünür olmasını bekler
        public void waitClassElement(string elementClass)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(elementClass)));
        }

        //Belirlenen Textin , CSS ile seçilen element içerisinde string olarak varolmasını bekler
        public void waitCssText(string elementCss, string elementText)
        {
            wait.Until(ExpectedConditions.TextToBePresentInElementLocated(By.Id(elementCss), elementText));
        }


        //Belirlenen Textin , Id ile seçilen element içerisinde string olarak varolmasını bekler
        public void waitIdText(string elementId, string elementText)
        {
            wait.Until(ExpectedConditions.TextToBePresentInElementLocated(By.Id(elementId), elementText));
        }

        //Belirlenen Textin , CSS ile seçilen element içerisinde string olarak varolmasını bekler
        public void waitXpathText(string elementXpath, string elementText)
        {
            wait.Until(ExpectedConditions.TextToBePresentInElementLocated(By.XPath(elementXpath), elementText));
        }

        public void InvisibilityOfElementLocatedClass(string elementClass)
        {
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName(elementClass)));
        }




    }
}