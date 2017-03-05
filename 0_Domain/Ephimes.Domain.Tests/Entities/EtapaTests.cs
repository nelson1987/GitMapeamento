using Ephimes.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ephimes.Domain.Tests.Entities
{
    [TestClass]
    public class EtapaTests
    {
        [TestMethod]
        public void CriarEtapa()
        {
            var etapa = new Etapa("Solicitação");
            Assert.AreEqual(etapa.Passos.Count, 0);
            Assert.AreEqual(etapa.Nome, "Solicitação");
        }
    }
}