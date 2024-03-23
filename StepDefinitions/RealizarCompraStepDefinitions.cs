using ProjetoTestesC.Actions;
using ProjetoTestesC.Elements;
using System;
using TechTalk.SpecFlow;

namespace ProjetoTestesC.StepDefinitions
{
    [Binding, Scope(Feature = "RealizarCompra")]
    public class RealizarCompraStepDefinitions
    {
        private RealizarCompraAction _realizarCompraAction = new RealizarCompraAction();

        [Given(@"Logar no site de compra")]
        public void EstarLogado()
        {
            _realizarCompraAction.AbrirLogin();
        }

        [When(@"Adicionar a mochila no carrinho")]
        public void AdicionarMochila()
        {
            _realizarCompraAction.ClicarNaMochila();
        }

        [When(@"Adicionar a camiseta no carrinho")]
        public void AdicionarCamiseta()
        {
            _realizarCompraAction.ClicarNaCamiseta();
        }

        [When(@"Clicar no carrinho")]
        public void ClicarNoCarrinho()
        {
            _realizarCompraAction.ClicarNoCarrinho();
        }

        [When(@"Clicar em checkout")]
        public void ClicarEmCheckout()
        {
            _realizarCompraAction.ClicarCheckout();
        }

        [When(@"Informar nome (.*)")]
        public void InformarNome(string nome)
        {
            _realizarCompraAction.PreencherNome(nome);
        }

        [When(@"Informar sobrenome (.*)")]
        public void InformarSobrenome(string sobrenome)
        {
            _realizarCompraAction.PreencherSobrenome(sobrenome);
        }

        [When(@"Informar CEP (.*)")]
        public void InformarCEP(string cep)
        {
            _realizarCompraAction.PreencherCep(cep);
        }

        [When(@"Clicar em continuar")]
        public void ClicarEmContinuar()
        {
            _realizarCompraAction.ClicarEmContinuar();
        }

        [When(@"Clicar em finish")]
        public void ClicarEmFinish()
        {
            _realizarCompraAction.ClicarEmFinalizar();
        }

        [Then(@"Mensagem de sucesso")]
        public void MensagemDeSucesso( )
        {
            _realizarCompraAction.CompraComSucesso();
        }
    }
}
