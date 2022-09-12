using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace IsometrixTests.Page_Objects.Base
{
	public class BaseFunctions : Elements
	{
		public void LaunchBrowser()
		{
			driver = new ChromeDriver();

			driver.Navigate().GoToUrl("https://qa01.isometrix.net/IsoMetrix.Automation.Features/default.aspx");
			Wait3Seconds();
			driver.Manage().Window.Maximize();
		}
		public void CloseBrowser()
		{
			driver.Quit();
		}
		public void Wait3Seconds()
		{
			Thread.Sleep(3000);
		}

	}
}
