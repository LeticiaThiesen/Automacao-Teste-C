using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoTestesC.Suport;
using System;
using System.Collections.Generic;
using System.Text;
using ProjetoTestesC.Suport;
using OpenQA.Selenium;
using System.Xml.Linq;

namespace ProjetoTestesC.Elements
{
    public class RealizarCompraMap
    {
        public By btnAddMochila = By.Id("add-to-cart-sauce-labs-backpack");
        public By btnAddCamiseta = By.Id("add-to-cart-sauce-labs-bolt-t-shirt");
        public By btnCarrinho = By.Id("shopping_cart_container");
        public By btnCheckout = By.Id("checkout");
        public By txtNome = By.Id("first-name");
        public By txtSobrenome = By.Id("last-name");
        public By txtCep = By.Id("postal-code");
        public By btnContinue = By.Id("continue");
        public By btnFinish = By.Id("finish");
        public By textoPagina = By.CssSelector("Thank you for your order!");
    }
}

