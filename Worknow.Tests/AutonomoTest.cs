using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controller;

namespace Worknow.Tests
{
    [TestClass]
    public class AutonomoTest
    {
        [TestMethod]
        public void CadastroAutonomo_ValidarCamposObrigatoriosPreenchidos()
        {
            string nome = "Amanda Lutke";
            string cpf = "123.456.780-00";
            string datadenascimento = "19/08/2000";
            string servicosprestados = "Programadora";
            string cep = "12345-678";
            string email = "amanda@mail.com";
            bool resultado = AutonomoController.CamposPreenchidosCadastroAutonomo(nome, cpf, datadenascimento, servicosprestados, cep, email);
            Assert.AreEqual(resultado, true);
        }

        [DataTestMethod]
        [DataRow("", "a", "a", "a", "a", "a")]
        [DataRow("a", "", "a", "a", "a", "a")]
        [DataRow("a", "a", "", "a", "a", "a")]
        [DataRow("a", "a", "a", "", "a", "a")]
        [DataRow("a", "a", "a", "a", "", "a")]
        [DataRow("a", "a", "a", "a", "a", "")]
        public void CadastroUsuario_ValidarCamposObrigatoriosNãoPreenchidos(
            string nome,
            string cpf,
            string datadenascimento,
            string servicosprestados,
            string cep,
            string email)
        {
            bool resultado = AutonomoController.CamposPreenchidosCadastroAutonomo(nome, cpf, datadenascimento, servicosprestados, cep, email);
            Assert.AreEqual(resultado, false);
        }
    }
}
