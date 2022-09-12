using System;
using IsometrixTests.Page_Objects.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.Automation.Framework;

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
			Wait3Seconds();
			driver.SwitchTo().Frame("ifrMain");
			Wait3Seconds();
			moduleC2.Click();
			Wait3Seconds();
			addBtn.Click();
			Wait3Seconds();
			moduleSources.Click();
			Wait3Seconds();
			modulesubsource.Click();

			string divHeader = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[2]/div[4]/div[7]/div[9]/div[2]/div[2]/div/div/div[9]/div[2]/div[2]/div/div[2]/div[1]")).Text.ToString();
			dropDown.Click();
			Wait3Seconds();

			driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[33]/ul[1]/ul/li[1]/i")).Click();
			driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[33]/ul[1]/ul/li[1]/a")).Click();
			driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[2]/div[4]/div[7]/div[9]/div[2]/div[2]/div/div/div[9]/div[2]/div[2]/div/div[10]/div[1]/div/ul[1]/ul/li[1]/a/i[1]")).Click();
			Wait3Seconds();

			string divHeader2 = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[2]/div[4]/div[7]/div[9]/div[2]/div[2]/div/div/div[9]/div[2]/div[2]/div/div[3]/div[1]")).Text.ToString();
			dropDown.Click();
			Wait3Seconds();

			driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[34]/ul[1]/ul/li[1]/i")).Click();
			driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[34]/ul[1]/ul/li[1]/a")).Click();
			driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[2]/div[4]/div[7]/div[9]/div[2]/div[2]/div/div/div[9]/div[2]/div[2]/div/div[11]/div[1]/div/ul[1]/ul/li[2]/a/i[1]")).Click();
			Wait3Seconds();

			string divHeader3 = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[2]/div[4]/div[7]/div[9]/div[2]/div[2]/div/div/div[9]/div[2]/div[2]/div/div[4]/div[1]")).Text.ToString();
			dropDown.Click();
			Wait3Seconds();

			driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[35]/ul[1]/ul/li[1]/i")).Click();
			driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[35]/ul[1]/ul/li[1]/ul/li/a")).Click();
			driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[2]/div[4]/div[7]/div[9]/div[2]/div[2]/div/div/div[9]/div[2]/div[2]/div/div[12]/div[1]/div/ul[1]/ul/li[1]/i")).Click();
			driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[2]/div[4]/div[7]/div[9]/div[2]/div[2]/div/div/div[9]/div[2]/div[2]/div/div[12]/div[1]/div/ul[1]/ul/li[1]/ul/li/a/i[1]")).Click();
			Wait3Seconds();

			string divHeader4 = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[2]/div[4]/div[7]/div[9]/div[2]/div[2]/div/div/div[9]/div[2]/div[2]/div/div[5]/div[1]")).Text.ToString();
			dropDown.Click();
			Wait3Seconds();

			driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[36]/ul[1]/ul/li[1]/i")).Click();
			driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[36]/ul[1]/ul/li[1]/ul/li/a")).Click();
			driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[2]/div[4]/div[7]/div[9]/div[2]/div[2]/div/div/div[9]/div[2]/div[2]/div/div[13]/div[1]/div/ul[1]/ul/li[1]/i")).Click();
			driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[2]/div[4]/div[7]/div[9]/div[2]/div[2]/div/div/div[9]/div[2]/div[2]/div/div[13]/div[1]/div/ul[1]/ul/li[1]/ul/li/a/i[1]")).Click();
			Wait3Seconds();
			saveBtn.Click();
			Wait3Seconds();

			string toasterMessage = txtHeader.Text.ToString();
			Assert.AreEqual("Record saved", toasterMessage);
			Wait3Seconds();
			driver.SwitchTo().DefaultContent();
			logoutBtn.Click();
			Wait3Seconds();
			CloseBrowser();
		}
	}
}
