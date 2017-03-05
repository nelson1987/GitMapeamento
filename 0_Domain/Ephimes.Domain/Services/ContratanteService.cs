using System;
using System.Collections.Generic;
using Ephimes.Domain.Builders;
using Ephimes.Domain.Entities;
using Ephimes.Domain.Entities.Categorias;
using Ephimes.Domain.Entities.Status;
using Ephimes.Domain.Entities.Tipos;
using Ephimes.Domain.Interfaces;

namespace Ephimes.Domain.Services
{
    public class ContratanteService : IContratanteService
    {
        public ContratanteService()
        {
            _contratante = new ClienteAncora("Samarco", new AplicacaoBuilder().Build());
        }

        public Contratante _contratante { get; private set; }
        //public void IncluirCategoria(CategoriaEmpresa categoria)
        //{
        //    _contratante.AdicionarCategoria(categoria);
        //    throw new NotImplementedException();
        //}

        public void IncluirFornecedor(Fornecedor empresa)
        {
            _contratante.AdicionarEmpresa(empresa);
        }

        public void IncluirPerfil(Perfil perfil)
        {
            _contratante.AdicionarPerfil(perfil);
        }

        public void IncluirPapel(Papel papel)
        {
            _contratante.AdicionarPapel(papel);
        }

        public void IncluirDocumento(Documento documento)
        {
            _contratante.AdicionarDocumento(documento);
        }

        public void IncluirCliente(Cliente empresa)
        {
            _contratante.AdcionarCliente(empresa);
        }

        public void IncluirFabricante(Fabricante empresa)
        {
            _contratante.AdicionarFabricante(empresa);
        }

        public void IncluirCategoria(CategoriaEmpresa categoria)
        {
            _contratante.AdicionarCategoria(categoria);
        }

        public void IncluirCategoria(CategoriaEmpresa categoria, List<Documento> documentos)
        {
            throw new NotImplementedException();
        }

        public void IncluirUsuario(Usuario usuario)
        {
            //    _contratante.AdicionarUsuario(usuario);
        }

        //public void IncluirCompartilhamento(Compartilhamento compartilhamento, FichaCompartilhada ficha,
        //    List<Email> emails)
        //{
        //    throw new NotImplementedException();
        //}

        public void IncluirContato(Contato contato)
        {
            throw new NotImplementedException();
        }

        public void IncluirBanco(Banco banco)
        {
            //_contratante.AdicionarBanco(banco);
        }

        public void IncluirImportacao(Importacao importacao)
        {
            _contratante.AdicionarImportacao(importacao);
        }

        public void IncluirSolicitacao(Solicitacao solicitacao)
        {
            throw new NotImplementedException();
        }

        public void IncluirStatusEmpresa(StatusEmpresa status)
        {
            throw new NotImplementedException();
        }

        public void IncluirPreCadastro(PreCadastro empresa)
        {
            throw new NotImplementedException();
        }

        public void IncluirEmpresa(Empresa empresa)
        {
            _contratante.AdicionarEmpresa(empresa);
        }
    }
}