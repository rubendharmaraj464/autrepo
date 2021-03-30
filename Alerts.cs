using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Docker.DotNet.Models;
using OpenQA.Selenium;
using excel = Microsoft.Office.Interop.Excel;


namespace TestAutomation
{
    class Alerts : Login
    {
        public void HandleAlerts(IWebDriver driver)
        {

        
            driver.Url = "https://the-internet.herokuapp.com/javascript_alerts";
            Thread.Sleep(5000);
      /*      driver.FindElement(By.XPath("//*[@id='content']/div/ul/li[1]/button")).Click();
            Thread.Sleep(5000);
            var alaertwindow = driver.SwitchTo().Alert();
            alaertwindow.Accept();*/


            driver.FindElement(By.XPath("//*[@id='content']/div/ul/li[2]/button")).Click();
            Thread.Sleep(5000);
            var alaertWin = driver.SwitchTo().Alert();
            String msg = alaertWin.Text;
            Console.WriteLine("Alert message is :"+ msg);
            alaertWin.Dismiss();







        }


    }
}
