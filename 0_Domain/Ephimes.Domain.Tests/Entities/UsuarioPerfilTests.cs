using Ephimes.Domain.Builders;
using Ephimes.Domain.Entities;
using Ephimes.Domain.Entities.Tipos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ephimes.Domain.Tests.Entities
{
    [TestClass]
    internal class UsuarioPerfilTests
    {
        [TestInitialize]
        public void SetUp()
        {
        }

        [TestMethod]
        public void CriarUsuario()
        {
            #region Usuarios

            var nelson = new Usuario("nelson.neto");
            var carlos = new Usuario("carlos.jesus");
            var diego = new Usuario("diego.messeri");

            #endregion

            #region Aplicações

            var webForLink = new AplicacaoBuilder().Nomeado("WFL").Descrito("WebForLink").Build();
            var webNotForn = new AplicacaoBuilder().Nomeado("WNF").Descrito("WebNotForn").Build();
            var webPourBreak = new AplicacaoBuilder().Nomeado("WPB").Descrito("WebPourBreak").Build();
            var vendorList = new AplicacaoBuilder().Nomeado("VL").Descrito("VendorList").Build();
            var surplus = new AplicacaoBuilder().Nomeado("SP").Descrito("Surplus").Build();

            #endregion

            var visualizador = new Perfil("Visualizador");
            var solicitante = new Perfil("Solicitante");
            var administrador = new Perfil("Administrador");

            //Nelson -> Aplicacoes
            nelson.AdicionarPerfilNumaAplicacao(webForLink, visualizador);
            nelson.AdicionarPerfilNumaAplicacao(webNotForn, administrador);
            nelson.AdicionarPerfilNumaAplicacao(webPourBreak, visualizador);
            //Carlos -> Aplicacoes
            carlos.AdicionarPerfilNumaAplicacao(vendorList, solicitante);
            //Diego -> Aplicacoes
            diego.AdicionarPerfilNumaAplicacao(surplus, administrador);

            Contratante SorteqWebForLink = new FornecedorIndividual("Sorteq"
                , new EmpresaPessoaJuridica(), webForLink);
            Contratante SorteqWebNotForn = new FornecedorIndividual("Sorteq"
                , new EmpresaPessoaJuridica(), webNotForn);
            Contratante SorteqWebPourBreak = new FornecedorIndividual("Sorteq"
                , new EmpresaPessoaJuridica(), webPourBreak);

            //fornecedorIndividual.AdicionarUsuario(nelson);
            //fornecedorIndividual.AdicionarUsuario(carlos);
            //fornecedorIndividual.AdicionarUsuario(diego);

            //--Validações
            Assert.AreEqual(nelson.Login, "nelson.neto");
            //Assert.AreEqual(nelson.Aplicacoes.Count, 3);
            //Assert.AreEqual(carlos.Aplicacoes.Count, 1);
            //Assert.AreEqual(diego.Aplicacoes.Count, 1);
            //Assert.AreEqual(nelson.Aplicacoes[0].Perfis.Count, 1);
            //Assert.AreEqual(nelson.Aplicacoes[1].Perfis.Count, 1);
            //Assert.AreEqual(nelson.Aplicacoes[2].Perfis.Count, 1);
            //Assert.AreEqual(fornecedorIndividual.Usuarios.Count, 1);
        }
    }
}