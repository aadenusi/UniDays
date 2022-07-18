using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

[Binding]
public class NavigationMenu
{
    String base_url = "https://www.myunidays.com/";
  private IWebDriver driver;


    //public NavigationMenu(ScenarioContext injectedContext)
    //{
    //    context = injectedContext;
    //}
  

    [Given(@"I am on myunidays Homepage")]
    [Test]
    public void GivenIAmOnMyunidaysHomepage()
    {
        driver = new FirefoxDriver();
        driver.Url = base_url;
        driver.Manage().Window.Maximize();
        System.Threading.Thread.Sleep(2000);
    }

    [When(@"I click on a navigation (.*)")]
    public void WhenIClickOnANavigationMenu(string menu)
    {
        IWebElement textfield = driver.FindElement(By.XPath("Limited time only!"));
       textfield.Click();
    }

    [Then(@"a content is displayed")]
    public void ThenAContentIsDisplayed()
    {
        throw new PendingStepException();
    }



}