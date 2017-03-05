using Ephimes.Domain.Builders;
using Ephimes.Domain.Entities;
using Ephimes.Domain.Entities.Tipos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ephimes.Domain.Tests.Entities
{
    [TestClass]
    public class SolicitacaoTests
    {
        private Usuario _nelson;
        private TipoEmpresa _pessoaJuridica;
        private Contratante _samarco;
        private Empresa _sorteq;
        private Aplicacao _webForLink;

        [TestInitialize]
        public void SetUp()
        {
            _webForLink = new AplicacaoBuilder().Nomeado("WebForLink").Descrito("Cadastro de Fornecedores").Build();
            _samarco = new ClienteAncora("Samarco", _webForLink);
            _nelson = new Usuario("nelson.neto", _samarco);
            _pessoaJuridica = new EmpresaPessoaJuridica();
            _sorteq = new Fornecedor("Sorteq", "12345678900", _pessoaJuridica);
        }

        [TestMethod]
        public void CriarSolicitacao()
        {
            Solicitacao criacaoFornecedor = new SolicitacaoCadastro(_nelson, _sorteq);
            Assert.AreEqual(criacaoFornecedor.Criador.Contratante, _nelson.Contratante);
            Assert.AreEqual(criacaoFornecedor.Contratante, _nelson.Contratante);
            Assert.AreEqual(criacaoFornecedor.Solicitado, _sorteq);
        }

        [TestMethod]
        public void CriarSolicitacaoCriacaoFornecedor()
        {
            Solicitacao criacaoFornecedor = new SolicitacaoCadastro(_nelson, _sorteq);
            Assert.AreEqual(criacaoFornecedor.Criador, _nelson);
            Assert.AreEqual(criacaoFornecedor.Contratante, _nelson.Contratante);
        }
    }
}