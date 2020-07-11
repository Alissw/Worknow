using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controller;

namespace Worknow.Tests
{
    [TestClass]
    public class EmpreendedorMEITest
    {
        [TestMethod]
        public void CadastroEmpreendedor_ValidarCamposObrigatoriosPreenchidos()
        {
            string razaosocial = "RLC Informatica";
            string nomefantasia = "Ricardinho Eletro";
            string cnpj = "11.111/111-11";
            string cep = "11111-111";
            string senha = "mei123";
            string confirmarsenha = "mei123";
            bool resultado = EmpreendedorMeiController.CamposPreenchidosCadastroEmpreendedorMEI(razaosocial, nomefantasia, cnpj, cep, senha, confirmarsenha);
            Assert.AreEqual(resultado, true);
        }

        [DataTestMethod]
        [DataRow("", "a", "a", "a", "a", "a")]
        [DataRow("a", "", "a", "a", "a", "a")]
        [DataRow("a", "a", "", "a", "a", "a")]
        [DataRow("a", "a", "a", "", "a", "a")]
        [DataRow("a", "a", "a", "a", "", "a")]
        [DataRow("a", "a", "a", "a", "a", "")]
        public void CadastroEmpreendedor_ValidarCamposObrigatoriosNãoPreenchidos(
            string razaosocial,
            string nomefantasia,
            string cnpj,
            string cep,
            string senha,
            string confirmarsenha)
        {
            bool resultado = EmpreendedorMeiController.CamposPreenchidosCadastroEmpreendedorMEI(razaosocial,nomefantasia, cnpj, cep, senha, confirmarsenha);
            Assert.AreEqual(resultado, false);
        }
        [TestMethod]
        public void EmpreendedorMei_ConfirmacaoDeSenhaCorreta()
        {
            string senha1 = "12345";
            string senha2 = "12345";
            bool resultado = EmpreendedorMeiController.ConfirmarSenhas(senha1, senha2);
            Assert.AreEqual(resultado, true);
        }
 
        [TestMethod]
        public void EmpreendedorMei_ConfirmacaoDeSenhaErrada()
        {
            string senha1 = "12345";
            string senha2 = "45678";
            bool resultado = EmpreendedorMeiController.ConfirmarSenhas(senha1, senha2);
            Assert.AreEqual(resultado, false);
        }
    }
}
