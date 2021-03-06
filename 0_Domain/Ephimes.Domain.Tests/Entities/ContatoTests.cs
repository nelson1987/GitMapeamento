﻿using Ephimes.Domain.Entities;
using Ephimes.Domain.Entities.Tipos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ephimes.Domain.Tests.Entities
{
    [TestClass]
    public class ContatoTests
    {
        [TestMethod]
        public void CriarContato()
        {
            var pauloDaSorteq = new Contato("Paulo", "nelson.neto@hotmail.com", "21 3456-7890", "21 93456-7890");
            Assert.AreEqual(pauloDaSorteq.Nome, "Paulo");
        }

        [TestMethod]
        public void AdicionarContatoAUmaEmpresa()
        {
            var pauloDaSorteq = new Contato("Paulo", "nelson.neto@hotmail.com", "21 3456-7890", "21 93456-7890");
            Empresa sorteq = new Fornecedor("Sorteq", "12345678900", new EmpresaPessoaJuridica());
            // new TipoEmpresa("Fornecedor"));
            sorteq.AdicionarContato(pauloDaSorteq);
        }
    }
}