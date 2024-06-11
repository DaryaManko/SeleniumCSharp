using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestProject1.BaseClass;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Threading;

namespace Selenium
{
    public class Tests : BaseTest
    {
        //[SetUp]
        // public void setup()
        // {
        // }

        [Test, Category("Smoke Testing")]
        public void Test1()
        {

            IWebElement emailTextField = driver.FindElement(By.CssSelector("input[name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            IWebElement monthDropDownList = driver.FindElement(By.CssSelector("select[id='month']"));
            SelectElement element = new SelectElement(monthDropDownList);
            element.SelectByValue("1");
            element.SelectByIndex(3);

        }

        [Test, Category("Regression Testing")]
        public void Test2()
        {

            IWebElement emailTextField = driver.FindElement(By.CssSelector("input[name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");

        }

        [Test, Category("Smoke Testing")]
        public void Test3()
        {

            IWebElement emailTextField = driver.FindElement(By.CssSelector("input[name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(5000);

        }

    }
}
