using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UiTests.pageObjects
{
     public class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "Username")]
        private IWebElement username;

        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement password;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement loginButton;

        public void ValidLogin(string username, string password)
        {
            TypeUserName().SendKeys(username);
            TypePassword().SendKeys(password);
            ClickButton().Click();  
        }
        public IWebElement TypePassword()
        {
            return password;
        }
        public IWebElement ClickButton()
        {
            return loginButton;
        }

        public IWebElement TypeUserName()
        {
            return username;
        }
    }
}
