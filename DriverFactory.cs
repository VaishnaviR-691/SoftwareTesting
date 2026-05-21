using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class DriverFactory
{
    public static IWebDriver InitDriver()
    {
        IWebDriver driver = new ChromeDriver();

        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        return driver;
    }
}