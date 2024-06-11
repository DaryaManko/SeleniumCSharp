using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium1
{
    [TestFixture]
    public class SeleniumCSharpTutorial04
    {
        string elementLocator = "input[name='reg_email__']";
        [Test]
        [Author("Darya","daryamanko@microsoft.wsei.edu.pl")]
        [Description("Facebook login verify")]
        [TestCaseSource("DataDrivenTesting")]
        public void Test1(String urlName)
        {
            IWebDriver driver = null;
            
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //driver.Url = "https://www.facebook.com/r.php";
                driver.Url = urlName;
                IWebElement emailTextField = driver.FindElement(By.CssSelector(elementLocator));
               // IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='abcd']"));
                emailTextField.SendKeys("Selenium C#");
                driver.Quit();
            }
            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                var filePath = "C:\\projects\\Selenium1\\Selenium1\\Screenshots\\file.";
                screenshot.SaveAsFile(filePath + System.Drawing.Imaging.ImageFormat.Png);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
            
        }

        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com/r.php");
           // list.Add("https://www.youtube.com/");
           // list.Add("https://www.microsoft.com/pl-pl/");

            return list;
        }

       // [Test]
        //[Author("Darya", "daryamanko@microsoft.wsei.edu.pl")]
       // [Description("Facebook login verify")]
      //  public void Test2()
       // {
          //  IWebDriver driver = new ChromeDriver();
          //  driver.Manage().Window.Maximize();
           // driver.Url = "https://www.facebook.com/r.php";
           // IWebElement emailTextField = driver.FindElement(By.CssSelector(elementLocator));
           // emailTextField.SendKeys("Selenium C#");
          //  driver.Close();
       // }
    }
}
