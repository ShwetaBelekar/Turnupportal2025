using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V133.HeapProfiler;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Data;

public class Program
{

    private static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();
        ChromeOptions options = new ChromeOptions();
        options.AddUserProfilePreference("profile.password_manager_leak_detection", false);
        driver = new ChromeDriver(options);

        driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
        driver.Manage().Window.Maximize();
        Thread.Sleep(3000);

        IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
        usernameTextbox.SendKeys("hari");

        IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
        passwordTextbox.SendKeys("123123");

        IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        loginButton.Click();
        Thread.Sleep(2000);

        IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

        if (hellohari.Text == "Hello hari!")
        {
            Console.WriteLine("User has logged in successfully. Test Passed!");
        }
        else
        {
            Console.WriteLine("User has not logged in. Test Failed!");
        }

        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        try
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }
        catch (WebDriverTimeoutException)
        {
            Console.WriteLine("Alert not present within the specified time.");
        }

        IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
        administrationTab.Click();

        IWebElement employeesOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
        employeesOption.Click();
        Thread.Sleep(30000);

        IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
        createButton.Click();


        IWebElement nameTextbox = driver.FindElement(By.Id("Name"));
        nameTextbox.SendKeys("Nisha");

        IWebElement uusernameTextbox = driver.FindElement(By.Id("Username"));
        uusernameTextbox.SendKeys("Nisha123");

        IWebElement contactTextbox = driver.FindElement(By.Id("ContactDisplay"));
        contactTextbox.SendKeys("Home001");
        Thread.Sleep(3000);

        IWebElement paasswordTextbox = driver.FindElement(By.Id("Password"));
        paasswordTextbox.SendKeys("Moon001!");

        IWebElement retypePasswordTextbox = driver.FindElement(By.Id("RetypePassword"));
        retypePasswordTextbox.SendKeys("Moon001!");

        IWebElement isAdminTickbox = driver.FindElement(By.Id("IsAdmin"));
        isAdminTickbox.Click();
        Thread.Sleep(2000);

        IWebElement vehicleTextbox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
        vehicleTextbox.SendKeys("Car");

        IWebElement groupsTextbox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
        groupsTextbox.Click();
        Thread.Sleep(3000);

        IWebElement icOption = driver.FindElement(By.XPath("//*[@id=\"groupList_listbox\"]/li[73]"));
        icOption.Click();

        IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
        saveButton.Click();


        IWebElement backToListButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
        backToListButton.Click();
        Thread.Sleep(3000);

        IWebElement goToTheLastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
        goToTheLastPageButton.Click();

        IWebElement newName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

        if (newName.Text == "Nisha")
        {
            Console.WriteLine("New Name record created Successfully!");
        }
        else
        {
            Console.WriteLine("New name record has not been created!");
        }

        IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
        lastPageButton.Click();

        IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[5]/td[3]/a[1]"));
        editButton.Click();
        Thread.Sleep(2000);

        IWebElement naameTextbox = driver.FindElement(By.Id("Name"));
        naameTextbox.Clear();
        naameTextbox.SendKeys("Asha");
        Thread.Sleep(2000);

        IWebElement saaveButton = driver.FindElement(By.Id("SaveButton"));
        saaveButton.Click();

        IWebElement baackToListButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
        baackToListButton.Click();
        Thread.Sleep(3000);

        IWebElement laastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
        laastPageButton.Click();

        IWebElement name = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[5]/td[1]"));
        if (name.Text == "Asha")
        {
            Console.WriteLine("Asha is Present!");
        }
        else
        {
            Console.WriteLine("Asha is not Present!");
        }

        IWebElement llaastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
        llaastPageButton.Click();
        Thread.Sleep(2000);

        IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[4]/td[3]/a[2]"));
        deleteButton.Click();
        driver.SwitchTo().Alert().Accept();

        IWebElement llaasstPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
        llaasstPageButton.Click();

        IWebElement naame = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[4]/td[1]"));

        if (naame.Text == "efg")
        {
            Console.WriteLine("efg is not present!");
        }
        else
        {
            Console.WriteLine("efg is present!");
        }

        IWebElement aadministrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
        aadministrationTab.Click();
        Thread.Sleep(3000);

        IWebElement customersOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a"));
        customersOption.Click();
        Thread.Sleep(2000);

        IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
        createNewButton.Click();

        IWebElement nameeTextbox = driver.FindElement(By.Id("Name"));
        nameeTextbox.SendKeys("Rani");


        IWebElement editContactButton = driver.FindElement(By.Id("EditContactButton"));
        //string mainWindowHandle = driver.CurrentWindowHandle;
        editContactButton.Click();
        driver.SwitchTo().Frame(0);

        //List<string> windowHandles = driver.WindowHandles.ToList();

        //string newWindowHandle = windowHandles.Last();

        //driver.SwitchTo().Window(newWindowHandle);

        //Thread.Sleep(5000);

        IWebElement firstNameTextbox = driver.FindElement(By.Id("FirstName"));
        firstNameTextbox.SendKeys("Road");

        IWebElement lastNameTextbox = driver.FindElement(By.Id("LastName"));
        lastNameTextbox.SendKeys("Way");

        IWebElement phoneTextbox = driver.FindElement(By.Id("Phone"));
        phoneTextbox.SendKeys("123");
        Thread.Sleep(2000);
        IWebElement saveContactButton = driver.FindElement(By.Id("submitButton"));
        saveContactButton.Click();

        driver.SwitchTo().ParentFrame();
        Thread.Sleep(2000);
        //driver.SwitchTo().Window(mainWindowHandle);

        IWebElement sameAsAboveTickbox = driver.FindElement(By.Id("IsSameContact"));
        sameAsAboveTickbox.Click();

        IWebElement gstTextbox = driver.FindElement(By.Id("GST"));
        gstTextbox.SendKeys("10");

        IWebElement ssaveButton = driver.FindElement(By.XPath("//input[@value='Save']"));
        ssaveButton.Click();
        Thread.Sleep(3000);
        IWebElement aadminiistrationtab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
        aadminiistrationtab.Click();

        IWebElement cuustomersOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a"));
        cuustomersOption.Click();
        Thread.Sleep(2000);

        IWebElement llaassttPageButton = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[4]/a[4]/span"));
        llaassttPageButton.Click();
        Thread.Sleep(2000);

        IWebElement neewName = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[2]/table/tbody/tr[last()]/td[2]"));

        if (neewName.Text == "Rani")
        {
            Console.WriteLine("New entry is created!");
        }
        else
        {
            Console.WriteLine("New entry is not been created!");
        }

        IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[4]/a[4]/span"));
        goToLastPageButton.Click();
        Thread.Sleep(2000);

        IWebElement eeditButton = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[2]/table/tbody/tr[7]/td[4]/a[1]"));
        eeditButton.Click();
        driver.SwitchTo().Frame(0);


        IWebElement naameeTextbox = driver.FindElement(By.Id("Name"));
        naameeTextbox.Clear();
        naameeTextbox.SendKeys("XYZ");

        IWebElement saveeButton = driver.FindElement(By.Id("submitButton"));
        saveeButton.Click();
        driver.SwitchTo().ParentFrame();
        driver.Navigate().Refresh();
        Thread.Sleep(2000);
        IWebElement llastPageButton = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[4]/a[4]/span"));
        llastPageButton.Click();
        Thread.Sleep(5000);

        IWebElement naamme = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[2]/table/tbody/tr[7]/td[2]"));

        if (naamme.Text == "XYZ")
        {
            Console.WriteLine("XYZ is Present");
        }
        else
        {
            Console.WriteLine("XYZ is not Present");
        }

        IWebElement lasstPageButton = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[4]/a[4]/span"));
        lasstPageButton.Click();

        IWebElement deeleteButton = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[2]/table/tbody/tr[5]/td[4]/a[2]"));
        deeleteButton.Click();
        driver.SwitchTo().Alert().Accept();

        IWebElement laasstPageButton = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[4]/a[4]/span"));
        laasstPageButton.Click();

        IWebElement id = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[2]/table/tbody/tr[5]/td[1]"));

        if (id.Text == "3452")
        {
            Console.WriteLine("3452 is not present");
        }
        else
        {
            Console.WriteLine("3452 is present");
        }

        IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
        administrationTab.Click();

        IWebElement companiesOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[6]/a"));
        companiesOption.Click();

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

        IWebElement nameTextbox = driver.FindElement(By.Id("Name"));
        nameTextbox.SendKeys("Pearl");

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
