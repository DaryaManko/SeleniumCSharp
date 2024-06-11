using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestProject1.BaseClass;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;

namespace Selenium
{
    public class OrderSkipAttribute 
    {
        string elementLocator = "input[name='reg_email__']";

        [Test,Order(2), Category("OrderSkipAttribute")]
        public void Test1()
        {
            Assert.Ignore("Defect 1234");
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/r.php";
            IWebElement emailTextField = driver.FindElement(By.CssSelector(elementLocator));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test,Order(1), Category("OrderSkipAttribute")]
        public void Test2()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/r.php";
            IWebElement emailTextField = driver.FindElement(By.CssSelector(elementLocator));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test,Order(0), Category("OrderSkipAttribute")]
        public void Test3()
        {
            IWebDriver driver = new EdgeDriver();
            driver.Url = "https://www.facebook.com/r.php";
            IWebElement emailTextField = driver.FindElement(By.CssSelector(elementLocator));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }


    }
}
