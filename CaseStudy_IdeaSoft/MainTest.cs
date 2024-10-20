using System;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Extensions;
using NUnit.Compatibility;
using NUnit;
using NUnit.Framework;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework.Legacy;
using CaseStudy_IdeaSoft;

namespace CaseStudy_IdeaSoft
{
    [TestFixture]
    public class MainTest : HomeClass
    {

        [Test]
        public void ideaSoft_Case()
        {
            try
            {
                findName("q").Click();
                sendName("q", "ürün" + Keys.Enter);
                waitXpathElement("//*[@id=\"results-page\"]/div[2]/div/div/div/div[1]/div[1]/a");
                findXpath("//*[@id=\"results-page\"]/div[2]/div/div/div/div[1]/div[1]/a").Click();
                var selectElement = driver.FindElement(By.Id("qty-input"));
                SelectElement select = new SelectElement(selectElement);
                select.SelectByValue("5");
                waitClassElement("add-to-cart-button");
                findClass("add-to-cart-button").Click();
                var successMessage = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("shopping-information-cart-inside"))).Text;
                Console.WriteLine("Sepet Ekleme Sonrası Uyarı Mesajı: " + successMessage);
                ClassicAssert.AreEqual("SEPETİNİZE EKLENMİŞTİR", successMessage, "Hatalı uyarı mesajı:" + successMessage);
                InvisibilityOfElementLocatedClass("shopping-information-cart");
                waitXpathElement("//*[@id=\"header\"]/div/div/div/div[3]/div/div[3]/a");
                findXpath("//*[@id=\"header\"]/div/div/div/div[3]/div/div[3]/a").Click();
                waitXpathElement("//*[@id=\"cart-items\"]/div/div/div[2]/div/div/div[2]/div/div/div/input");
                var qty = driver.FindElement(By.XPath("//*[@id=\"cart-items\"]/div/div/div[2]/div/div/div[2]/div/div/div/input"));
                var basketValue = qty.GetAttribute("value");
                Console.WriteLine("Sepetteki Ürün Sayısı: " + basketValue);
                ClassicAssert.AreEqual("5", basketValue, "Sepette hatalı miktarda ürün bulunmaktadır. Ürün Sayısı:" + basketValue);
                Console.WriteLine("Otomasyon Başarıyla Tamamlandı.");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Hata: {ex.Message}");
            }


        }
    }
}