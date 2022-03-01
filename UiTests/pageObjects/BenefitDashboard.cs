using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UiTests.pageObjects
{
    public class BenefitDashboard
    {
        private IWebDriver driver;
 

        public BenefitDashboard(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "add")]//Add Employee button
        private IWebElement addEmployee;
        [FindsBy(How = How.Id, Using = "firstName")]
        private IWebElement firstName;
        [FindsBy(How = How.Id, Using ="lastName")]
        private IWebElement lastName;
        [FindsBy(How = How.Id, Using = "dependants")]
        private IWebElement dependents;
        [FindsBy(How = How.Id, Using = "addEmployee")]
        private IWebElement saveEmployee;
        [FindsBy(How = How.XPath, Using = "//button[@data-dismiss='modal']")]
        private IWebElement cancel;

        //driver.FindElement(By.XPath("//button[@data-dismiss='modal']")).Click();//Click Cancel on new emp modal

        public IWebElement SelectAddEE()
        {
            return addEmployee;
        }

        public  IWebElement Cancel()
        {
            return cancel;
        }

        public IWebElement TypeEeFirstName()
        {
            return firstName;
        }
        public IWebElement TypeEeLastName()
        {
            return lastName;
        }
        public IWebElement NumberOfDependents()
        {
                return dependents;
        }
        public IWebElement SaveEmployee()
        {
            return saveEmployee;
        }

    }
}
