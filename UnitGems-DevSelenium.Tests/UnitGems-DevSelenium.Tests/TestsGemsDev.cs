using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using Xunit;

namespace UnitGems_DevSelenium.Tests
{
    public class TestsGemsDev
    {
        public bool FindElementsNavigateGemsDev()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://gemsdev.ru/geometa/");
            try
            {
                driver.FindElement(By.CssSelector("body > section.my-150 > div > div > div.col-12.col-md-6.fadeInDown > h1"));
                driver.FindElement(By.CssSelector("body > section.gos-system.bg_circle > div.container > div:nth-child(1) > div.col-12.col-md-6.mb-5.mb-md-0.wow.fadeInUp > h2"));
                driver.FindElement(By.CssSelector("body > section.urban-analytics > div > div > div.col-12.col-md-6.wow.fadeInUp > h2"));
                driver.FindElement(By.CssSelector("body > section.other-products.bg_circle > div.container > h2"));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public bool FindLinksNavigateGemsDev()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://gemsdev.ru/geometa/");
            try
            {
                driver.FindElements(By.LinkText("https://xn--c1aaceme9acfqh.xn--p1ai/"));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        [Fact]
        public void CheckElements()
        {
            Assert.True(FindElementsNavigateGemsDev());
        }

        [Fact]
        public void CheckLinks()
        {
            Assert.True(FindLinksNavigateGemsDev());
        }
    }
}
