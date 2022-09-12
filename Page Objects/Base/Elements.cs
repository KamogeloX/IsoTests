using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace IsometrixTests.Page_Objects.Base
{
	public class Elements
	{
		public IWebDriver driver;
		public TestContext TestContext { get; set; }

		//Login Page
		public IWebElement txtUsername => driver.FindElement(By.Id("txtUsername"));
		public IWebElement txtPassword => driver.FindElement(By.Id("txtPassword"));
		public IWebElement loginBtn => driver.FindElement(By.Id("btnLoginSubmit"));

		//HomePage
		public IWebElement moduleC2 => driver.FindElement(By.XPath("/html/body/div/div[3]/div/div/div/div/div[11]/div[2]"));

		//Module C2
		public IWebElement addBtn => driver.FindElement(By.Id("btnActAddNew"));
		public IWebElement moduleSources => driver.FindElement(By.XPath("//div[text()='Module Sources']"));
		public IWebElement modulesubsource => driver.FindElement(By.XPath("//div[text()='Module A2 - Specific']"));

	}
}
