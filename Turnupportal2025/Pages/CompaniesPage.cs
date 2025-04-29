using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnupportal2025.Pages
{
    public class CompaniesPage
    {
        public void CreateCompaniesRecord(IWebDriver driver)
        {
            
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            IWebElement nameTextbox = driver.FindElement(By.Id("Name"));
            nameTextbox.SendKeys("Sony");

            IWebElement editContactButton = driver.FindElement(By.Id("EditContactButton"));
            editContactButton.Click();
            driver.SwitchTo().Frame(0);

            IWebElement firstNameTextbox = driver.FindElement(By.Id("FirstName"));
            firstNameTextbox.SendKeys("Tony");

            IWebElement lastNameTextbox = driver.FindElement(By.Id("LastName"));
            lastNameTextbox.SendKeys("tom");

            IWebElement phoneTextbox = driver.FindElement(By.Id("Phone"));
            phoneTextbox.SendKeys("456");

            IWebElement saveContactButton = driver.FindElement(By.Id("submitButton"));
            saveContactButton.Click();

            driver.SwitchTo().ParentFrame();

            IWebElement createNewGroupButton = driver.FindElement(By.Id("CreateGroupButton"));
            createNewGroupButton.Click();
            driver.SwitchTo().Frame(2);

            IWebElement naameTextbox = driver.FindElement(By.Id("Name"));
            naameTextbox.SendKeys("Pearl");

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            driver.SwitchTo().ParentFrame();

            IWebElement saveCompanyButton = driver.FindElement(By.Id("SaveButton"));
            saveCompanyButton.Click();

            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"companiesGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement newName = driver.FindElement(By.XPath("//*[@id=\"companiesGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newName.Text == "Sony")
            {
                Console.WriteLine(" Sony is not present");
            }
            else
            {
                Console.WriteLine("Sony is present");
            }

        }
    }
}
