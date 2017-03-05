using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ephimes.Domain.Entities;
using System.Collections.Generic;
using Ephimes.Domain.Entities.Tipos;

namespace Ephimes.Domain.Tests.Entities
{
    [TestClass]
    public class FichaTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ficha = new FichaCompartilhada(new Compartilhamento(new Usuario("nelson"), new List<Documento>()));

        }
    }
}
