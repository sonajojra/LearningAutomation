using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

//Open Chrome Browser
IWebDriver webDriver = new ChromeDriver();
webDriver.Manage().Window.Maximize();

//Launch turnup portal and navigate to login page
webDriver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");

//Identify the username textbox and enter valid username
IWebElement usernametextbox = webDriver.FindElement(By.Id("UserName"));
usernametextbox.SendKeys("hari");

//Identify the password textbox and enter valid password
IWebElement passwordtextbox = webDriver.FindElement(By.Id("Password"));
passwordtextbox.SendKeys("123123");

//Identify login button and click on the button
IWebElement loginbutton = webDriver.FindElement(By.XPath("//*[@id= 'loginForm']/form/div[3]/input[1]"));
loginbutton.Click();

//Check if user has logged in successfully
IWebElement helloHariLink = webDriver.FindElement(By.XPath("//*[@id= 'logoutForm']/ul/li/a"));
if (helloHariLink.Text == "hello Hari!")
{
    Console.WriteLine("user has looged in successsfully");
}
else
{
    Console.WriteLine("user hasn't been looged in");
}



