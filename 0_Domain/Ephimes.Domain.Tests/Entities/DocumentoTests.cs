﻿using Ephimes.Domain.Entities;
using Ephimes.Domain.Entities.Tipos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ephimes.Domain.Tests.Entities
{
    [TestClass]
    public class DocumentoTests
    {
        [TestMethod]
        public void CriarDocumento()
        {
            var carteiraDeHabilitacao = new Documento("CNH - Carteira Nacional de Habilitação");
            Assert.AreEqual(carteiraDeHabilitacao.Arquivos.Count, 0);
        }

        [TestMethod]
        public void AdicionarDocumentoParaUmaEmpresa()
        {
            var carteiraDeHabilitacao = new Documento("CNH - Carteira Nacional de Habilitação");
            Empresa sorteq = new Fornecedor("Sorteq", "12345678900", new EmpresaPessoaJuridica());
            //new TipoEmpresa("Fornecedor"));
            sorteq.AdicionarDocumento(carteiraDeHabilitacao);
            Assert.AreEqual(sorteq.FichaCadastral.Anexos.Count, 1);
            Assert.AreEqual(carteiraDeHabilitacao.Arquivos.Count, 0);
        }
    }
}