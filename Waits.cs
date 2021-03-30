using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestAutomation
{
    class Waits : Login  
    {
        public void ImplicitWait(IWebDriver driver)
        {

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.LinkText("This is a Ajax link")).Click();
            String message = driver.FindElement(By.ClassName("ContactUs")).Text;
           Console.WriteLine( message.Contains("Groovy"));
  
       }

        public void ExplicittWait(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            driver.FindElement(By.LinkText("This is a Ajax link")).Click();
            wait.Until(ExpectedConditions.ElementExists(By.ClassName("ContactUs")));
            String message = driver.FindElement(By.ClassName("ContactUs")).Text;
            Console.WriteLine(message.Contains("Ruben"));

            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("D:\\SeleniumC#\\Screenshots\\ContactUs.png", ScreenshotImageFormat.Png);



        }
    }
}
