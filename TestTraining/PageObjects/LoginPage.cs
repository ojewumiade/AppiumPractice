using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTraining.PageObjects
{
   public class LoginPage
    {
        [FindsBy(How = How.LinkText, Using = "Login")]
        private IWebElement login;

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement Email;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement Password;

        //<button type = "submit" class="le-button huge">Secure Sign In</button>

          [FindsBy(How = How.ClassName, Using = "le-button huge")]
        private IWebElement SignIn;

        public Void ClickLogin()
        {
            login.Click();
        }

        internal void EnterMyUsername()
        {
            throw new NotImplementedException();
        }

        internal void EnterMyPassword()
        {
            throw new NotImplementedException();
        }
    }
}
