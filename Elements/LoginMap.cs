using ProjetoTestesC.Suport;
using System;
using System.Collections.Generic;
using System.Text;
using ProjetoTestesC.Suport;
using OpenQA.Selenium;

namespace ProjetoTestesC.Elements
{
    public class LoginMap
    {
        public string URL = "https://www.saucedemo.com/";

        public By txtUserName = By.Id("user-name");
        public By txtPassword = By.Id("password");
        public By txtPasswordCss = By.CssSelector("#password");
        public By btnLogin = By.CssSelector("#login-button");
        public By btnLoginId = By.Id("login-button");
        public By btnLoginXpath = By.XPath("//*[@data-test=\"login-button\"]");
        public By textoPagina = By.XPath("//*[@id=\"header_container\"]/div[2]/span");
    }
}

