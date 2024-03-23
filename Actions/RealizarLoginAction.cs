using ProjetoTestesC.Elements;
using ProjetoTestesC.Suport;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTestesC.Actions
{
    public class RealizarLoginAction
    {
        private LoginMap _loginMap = new LoginMap();

        public void AbrirLogin()
        {
            ActionHelper.AbrirPaginaEsperarClique(_loginMap.URL);
        }

        public void DigitarUsuario(string usuario)
        {
            ActionHelper.PreencherInput(_loginMap.txtUserName, usuario);
        }

        public void DigitarSenha(string senha)
        {
            ActionHelper.PreencherInput(_loginMap.txtPasswordCss, senha);
        }

        public void ClicarEmLogin()
        {
            ActionHelper.ClicarBotao(_loginMap.btnLogin);
        }
       
        public bool VerificarSeEntrou()
        {
            return ActionHelper.Entrou();
          
        }
    }
}

