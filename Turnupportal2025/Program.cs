using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V133.HeapProfiler;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Data;
using Turnupportal2025.Pages;

public class Program
{

    private static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();
        ChromeOptions options = new ChromeOptions();
        options.AddUserProfilePreference("profile.password_manager_leak_detection", false);
        driver = new ChromeDriver(options);

        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginActions(driver);

        loginPageObj.VerifyUserInHomePage(driver);

        EmployeeHomePage employeeHomePageObj = new EmployeeHomePage();
        employeeHomePageObj.NavigateToEmployeesPage(driver);

        EmployeePage employeePageObj = new EmployeePage();
        employeePageObj.CreateEmployeeRecord(driver);

        employeePageObj.EditEmployeeRecord(driver);

        employeePageObj.DeleteEmployeeRecord(driver);

        
    }
}
