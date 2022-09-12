using System;
using IsometrixTests.Page_Objects.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace IsometrixTests
{
	[TestClass]
	public class TC_IsometrixTests : BaseFunctions
	{
		[TestMethod]
		public void TC_Login()
		{
			string UserName = "Candi1";
			string Password = "Candi1!";

			LaunchBrowser();
			txtUsername.SendKeys(UserName);
			txtPassword.SendKeys(Password);
			loginBtn.Click();
			Wait2Seconds();
			driver.SwitchTo().Frame("ifrMain");
			Wait2Seconds();
			moduleC2.Click();
			Wait2Seconds();
			addBtn.Click();
			Wait2Seconds();
			moduleSources.Click();
			Wait2Seconds();
			modulesubsource.Click();
			CloseBrowser();
		}
	}
}
