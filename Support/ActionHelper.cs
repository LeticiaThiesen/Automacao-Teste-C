using ProjetoTestesC.Suport;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Xml.Linq;
using TechTalk.SpecFlow;
using ProjetoTestesC.Elements;


namespace ProjetoTestesC.Suport
{
    public class ActionHelper
    {
        public static void AbrirPagina(string url)
        {
            Hook._driver.Navigate().GoToUrl(url);
            Esperar(2000);
        }

        public static void AbrirPaginaEsperarClique(string url)
        {
            Hook._driver.Navigate().GoToUrl(url);
            
        }

        public static void Esperar(int milisegundos)
        {
            Thread.Sleep(milisegundos);
        }
        public static void PreencherInput(By imput, string texto)
        {
            Hook._driver.FindElement(imput).SendKeys(texto);
        }

        public static void ClicarReadOnly(IWebElement label)
        {
            // Usando JavaScript para forçar o clique no elemento readonly
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)Hook._driver;
            jsExecutor.ExecuteScript("arguments[0].click();", label);
        }

        public static void ScrollPeloTeclado(IWebElement opcoes)
        {
            for (int i = 0; i < 8; i++)
            {
                opcoes.SendKeys(Keys.ArrowDown);
                Thread.Sleep(1000);
            }
        }

        public static void ScrollDoMouseParaBaixo()
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)Hook._driver;
            jsExecutor.ExecuteScript("window.scrollBy(0, 250);");
        }

        public static void ScrollDoMouseParaCima()
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)Hook._driver;
            jsExecutor.ExecuteScript("window.scrollBy(0, -250);");
        }

        public static void PressionarEnter(IWebElement enter)
        {
            enter.SendKeys(Keys.Enter);
        }

        public static void SelecionarOpcao(IWebElement opcao)
        {
            opcao.Click();
            Esperar(800);
        }

        public static void ClicarBotao(By botao)
        {
            Hook._driver.FindElement(botao).Click();
            Esperar(800);
        }
        
        public static void SelecionarCampo(IWebElement campo)
        {
            campo.SendKeys(Keys.Control + "a");
        }

        public static void ApagarCampo(IWebElement campo)
        {
            campo.SendKeys(Keys.Control + "a");
            campo.SendKeys(Keys.Delete);
        }

        public static bool Entrou()
        {
            var div = Hook._driver.FindElements(By.XPath(MapHelper.Mensagem));
            bool entrouNaPagina = div.Count == 1;

            return (entrouNaPagina);

        }

        public static bool CompraComSucesso()
        {
            var div = Hook._driver.FindElements(By.XPath(MapHelper.Mensagem));
            bool entrouNaPagina = div.Count == 1;

            return (entrouNaPagina);

        }

        public static void Logar()
        {
            LoginMap loginMap = new LoginMap();

            AbrirPaginaEsperarClique(loginMap.URL);
            PreencherInput(loginMap.txtUserName, "standard_user");
            PreencherInput(loginMap.txtPassword, "secret_sauce");
            ClicarBotao(loginMap.btnLoginId);
        }

    }
}

