using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestProject1.BaseClass;
using OpenQA.Selenium.Support.UI;
using TestProject1.Utilities;
using NUnit.Framework;

namespace Selenium
{
    [TestFixture]
    public class ParallelTesting

    {
        //[SetUp]
        // public void setup()
        // {
        // }
        IWebDriver driver;

        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test1()
        {
            var Driver = new BrowserUtilities().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.CssSelector("input[name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();


        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test2()
        {
            var Driver = new BrowserUtilities().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.CssSelector("input[name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();


        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test3()
        {
            var Driver = new BrowserUtilities().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.CssSelector("input[name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();


        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test4()
        {
            var Driver = new BrowserUtilities().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.CssSelector("input[name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();


        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test5()
        {
            var Driver = new BrowserUtilities().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.CssSelector("input[name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();


        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test6()
        {
            var Driver = new BrowserUtilities().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.CssSelector("input[name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();


        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test7()
        {
            var Driver = new BrowserUtilities().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.CssSelector("input[name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();


        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test8()
        {
            var Driver = new BrowserUtilities().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.CssSelector("input[name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();


        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test9()
        {
            var Driver = new BrowserUtilities().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.CssSelector("input[name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();


        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test10()
        {
            var Driver = new BrowserUtilities().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.CssSelector("input[name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();


        }


    }
}