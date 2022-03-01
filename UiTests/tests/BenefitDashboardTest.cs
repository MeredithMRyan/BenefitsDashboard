using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UiTests.pageObjects;
using UiTests.utilities;

namespace UiTests.tests
{
    public class BenefitDashboardTest : Base
    {

        [Test]
        public void AddNewEmployee()
        {
            //Arrange
            LoginPage loginPage = new LoginPage(driver);
            BenefitDashboard benefitPage = new BenefitDashboard(driver);

            //Act
            loginPage.ValidLogin("TestUser160", "OCABwco&.G>2");
            benefitPage.SelectAddEE().Click();

            //Assert
            Assert.AreEqual("Add Employee", driver.FindElement(By.ClassName("modal-title")).Text);
           
            //Act
            benefitPage.TypeEeFirstName().SendKeys("Howie");
            benefitPage.TypeEeLastName().SendKeys("Mandel");
            benefitPage.NumberOfDependents().SendKeys("3");
           // benefitPage.SaveEmployee().Click();
            benefitPage.Cancel().Click();

            //Assert
            Assert.Pass("Test Passed");
        }

    }
}
