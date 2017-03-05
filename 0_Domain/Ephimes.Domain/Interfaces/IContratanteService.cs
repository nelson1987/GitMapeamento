using System.Collections.Generic;
using Ephimes.Domain.Entities;
using Ephimes.Domain.Entities.Categorias;
using Ephimes.Domain.Entities.Status;
using Ephimes.Domain.Entities.Tipos;

namespace Ephimes.Domain.Interfaces
{
    public interface IContratanteService
    {
        void IncluirFornecedor(Fornecedor empresa);
        void IncluirPerfil(Perfil perfil);
        void IncluirPapel(Papel papel);
        void IncluirDocumento(Documento documento);
        void IncluirCliente(Cliente empresa);
        void IncluirFabricante(Fabricante empresa);
        void IncluirCategoria(CategoriaEmpresa categoria);
        void IncluirCategoria(CategoriaEmpresa categoria, List<Documento> documentos);
        void IncluirUsuario(Usuario usuario);
        //void IncluirCompartilhamento(Compartilhamento compartilhamento, FichaCompartilhada ficha, List<Email> emails);
        //void IncluirDestinatario(Destinatario destinatario);
        void IncluirContato(Contato contato);
        void IncluirBanco(Banco banco);
        void IncluirImportacao(Importacao importacao);
        void IncluirSolicitacao(Solicitacao solicitacao);
        void IncluirStatusEmpresa(StatusEmpresa status);
        void IncluirPreCadastro(PreCadastro empresa);
    }
}