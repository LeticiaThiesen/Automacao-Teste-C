using ProjetoTestesC.Elements;
using ProjetoTestesC.Suport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoTestesC.Elements;
using ProjetoTestesC.Suport;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using ProjetoTestesC.Elements;

namespace ProjetoTestesC.Actions
{
    public class RealizarCompraAction
    {
        private RealizarCompraMap _realizarCompraMap = new RealizarCompraMap();

        public void AbrirLogin()
        {
            ActionHelper.Logar();
            ActionHelper.Entrou();
        }

        public void ClicarNaMochila()
        {
            ActionHelper.ClicarBotao(_realizarCompraMap.btnAddMochila);
        }

        public void ClicarNaCamiseta()
        {
            ActionHelper.ClicarBotao(_realizarCompraMap.btnAddCamiseta);
        }

        public void ClicarNoCarrinho()
        {
            ActionHelper.ScrollDoMouseParaCima();
            ActionHelper.ClicarBotao(_realizarCompraMap.btnCarrinho);
        }

        public void ClicarCheckout()
        {
            ActionHelper.ClicarBotao(_realizarCompraMap.btnCheckout);
        }

        public void PreencherNome(string nome)
        {
            ActionHelper.PreencherInput(_realizarCompraMap.txtNome, nome);
        }

        public void PreencherSobrenome(string sobrenome)
        {
            ActionHelper.PreencherInput(_realizarCompraMap.txtSobrenome, sobrenome);
        }

        public void PreencherCep(string cep)
        {
            ActionHelper.PreencherInput(_realizarCompraMap.txtCep, cep);
        }

        public void ClicarEmContinuar()
        {
            ActionHelper.ClicarBotao(_realizarCompraMap.btnContinue);
        }

        public void ClicarEmFinalizar()
        {
            ActionHelper.ClicarBotao(_realizarCompraMap.btnFinish);
        }     

        public void CompraComSucesso()
        {
            ActionHelper.CompraComSucesso();
        }
    }
}


