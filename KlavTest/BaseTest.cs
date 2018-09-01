using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace KlavTest
{
    [TestFixture]
    class BaseTest
    {
        private IWebDriver driver;

        [OneTimeSetUp]
        public virtual void FirstInitialize()
        {

        }

    }
}
