using Ephimes.Domain.Builders;
using Ephimes.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ephimes.Domain.Tests.Entities
{
    [TestClass]
    public class AplicacaoTests
    {
        private Aplicacao webforlink;

        [TestInitialize]
        public void SetUp()
        {
            webforlink = new AplicacaoBuilder()
                .Nomeado("WebForLink")
                .Descrito("Cadastro de Fornecedores")
                .Build();
        }

        [TestMethod]
        public void CriarAplicacao()
        {
            Assert.AreEqual(webforlink.Nome, "WebForLink");
            Assert.AreEqual(webforlink.Descricao, "Cadastro de Fornecedores");
        }
    }
}