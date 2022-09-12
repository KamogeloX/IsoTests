using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace IsometrixTests.Page_Objects.Base
{
	public class BaseFunctions : Elements
	{
		public void LaunchBrowser()
		{
			driver = new ChromeDriver();

			driver.Navigate().GoToUrl("https://qa01.isometrix.net/IsoMetrix.Automation.Features/default.aspx");
			Wait2Seconds();
			driver.Manage().Window.Maximize();
		}
		public void CloseBrowser()
		{
			driver.Quit();
		}
		public void Wait2Seconds()
		{
			Thread.Sleep(2000);
		}

	}
}
