using NUnit.Framework;
using OpenQA.Selenium;

[TestFixture]
public class LoginTests
{
    IWebDriver driver;

    LoginPage loginPage;
    ProductsPage productsPage;

    [SetUp]
    public void Setup()
    {
        driver = DriverFactory.InitDriver();

        driver.Navigate().GoToUrl("https://www.saucedemo.com/");

        loginPage = new LoginPage(driver);
        productsPage = new ProductsPage(driver);
    }

    [Test]
    public void Verify_Login_And_Logout()
    {
        // Login
        loginPage.Login("standard_user", "secret_sauce");

        // Assertion
        Assert.That(
            productsPage.IsLoginSuccessful(),
            Is.True,
            "Login Failed"
        );

        // Navigation
        productsPage.OpenMenu();

        // Logout
        productsPage.Logout();

        // Assertion
        Assert.That(
            productsPage.IsLogoutSuccessful(),
            Is.True,
            "Logout Failed"
        );
    }

    [TearDown]
    public void TearDown()
    {
        if (driver != null)
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}