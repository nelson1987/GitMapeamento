using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ephimes.Domain.Builders;
using Ephimes.Domain.Entities;

namespace Ephimes.Domain.Tests.Entities
{
    [TestClass]
    public class PerfilTests
    {
        [TestMethod]
        public void CriarPerfil()
        {
            var webforLink = new AplicacaoBuilder().Nomeado("WebForLink").Descrito("Cadastro De Fornecedores").Build();
            var administrador = new Perfil("Administrador");
            webforLink.AdicionarPerfil(administrador);
            Assert.AreEqual(webforLink.Perfis.Count, 1);
            Assert.AreEqual(webforLink.Perfis[0].Nome, "Administrador");
        }
    }
}