
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Threading;

using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CRM_GTMK.Visual
{
	public partial class BrowserPult : Form 
	{
		IWebDriver driver;
		public BrowserPult()
		{
			InitializeComponent();
			
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			driver = new ChromeDriver();
			driver.Navigate().GoToUrl("https://smartcat.ai/sign-in?");
			driver.Close();
		}
	}
}
