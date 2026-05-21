using OpenQA.Selenium;

public class LoginPage
{
    private IWebDriver driver;

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    // Locators
    private By usernameField = By.Id("user-name");
    private By passwordField = By.Id("password");
    private By loginButton = By.Id("login-button");

    // Actions
    public void EnterUsername(string username)
    {
        driver.FindElement(usernameField).SendKeys(username);
    }

    public void EnterPassword(string password)
    {
        driver.FindElement(passwordField).SendKeys(password);
    }

    public void ClickLogin()
    {
        driver.FindElement(loginButton).Click();
    }

    public void Login(string username, string password)
    {
        EnterUsername(username);
        EnterPassword(password);
        ClickLogin();
    }
}
