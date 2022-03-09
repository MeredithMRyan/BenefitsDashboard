using NUnit.Framework;
using OpenQA.Selenium;
using UiTests.pageObjects;
using UiTests.utilities;

namespace UiTests
{
    public class LoginTests : Base
    {
        [Test]
        public void Login()
        {
            LoginPage loginPage= new LoginPage(driver);

            loginPage.TypeUserName().SendKeys("TestUser160");
            loginPage.TypePassword().SendKeys("OCABwco&.G>2");
            loginPage.ClickButton().Click();

            Assert.AreEqual("Employees - Paylocity Benefits Dashboard", driver.Title);
        }
    }
}