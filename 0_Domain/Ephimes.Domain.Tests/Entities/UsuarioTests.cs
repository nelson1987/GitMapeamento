using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ephimes.Domain.Tests.Entities
{
    [TestClass]
    public class UsuarioTests
    {
        private Usuario usuario;

        [TestInitialize]
        public void SetUp()
        {
            usuario = new Usuario("nelson.neto");
        }

        [TestMethod]
        public void CriarUsuario()
        {
            Assert.AreEqual("nelson.neto", usuario.Login);
        }
    }
}