using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace FindMyPastTechTest.Tests.Tests
{
    [TestFixture]
    class UserControlls
    {
        FirefoxDriver firefox;
        [SetUp]
        public void Init()
        { 
            firefox = new FirefoxDriver(); 
        }

        [TearDown]
        public void Dispose()
        { 
            firefox.Quit(); 
        }

        [Test]
        public void Are_The_Number_Box_And_Button_Present()
        {
            firefox.Navigate().GoToUrl("http://localhost:5050/");
            Assert.AreEqual(true, firefox.FindElement(By.Id("NumberBox")).Displayed);
            Assert.AreEqual(true, firefox.FindElement(By.Id("GenerateButton")).Displayed); 
        }
    }
}
