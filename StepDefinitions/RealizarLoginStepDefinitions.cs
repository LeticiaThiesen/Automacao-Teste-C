using ProjetoTestesC.Actions;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ProjetoTestesC.StepDefinitions
{
    [Binding, Scope(Feature = "RealizarLogin")]
    public class RealizarLoginStepDefinitions
    {
        private RealizarLoginAction _realizarLoginAction = new RealizarLoginAction();

        [Given(@"Estar na pagina de login")]
        public void AbrirPagina()
        {
            _realizarLoginAction.AbrirLogin();
        }

        [When(@"Digitar usuario (.*)")]
        public void DigitarUsuario(string texto)
        {
            _realizarLoginAction.DigitarUsuario(texto);
        }

        [When(@"Digitar senha (.*)")]
        public void DigitarSenha(string texto)
        {
            _realizarLoginAction.DigitarSenha(texto);
        }

        [When(@"Clicar em Login")]
        public void ClicarLogin()
        {
            _realizarLoginAction.ClicarEmLogin();
        }

        [Then(@"Procura titulo da pagina")]
        public void EstouDentro()
        {
            var dentro = _realizarLoginAction.VerificarSeEntrou();

            Assert.IsTrue(dentro);
        }
    }
}
