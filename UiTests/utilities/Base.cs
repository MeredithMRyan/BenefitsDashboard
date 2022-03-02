using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace UiTests.utilities
{
    public class Base
    {
        public IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            //string browserName = ConfigurationManager.AppSettings["browser"];
            InitializeBrowser("Edge");
            driver.Manage().Window
                  .Maximize();
            driver.Url = "https://wmxrwq14uc.execute-api.us-east-1.amazonaws.com/Prod/Account/Login";
        }

        public void InitializeBrowser(string browserName)
        {
            switch(browserName)
            {
                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;

                case "Edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    break;
            }

        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
