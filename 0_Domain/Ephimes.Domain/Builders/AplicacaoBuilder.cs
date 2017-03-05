using WebForLink.Domain.Entities;

namespace Ephimes.Domain.Builders
{
    public class AplicacaoBuilder
    {
        public AplicacaoBuilder()
        {
            Aplicacao = new Aplicacao();
            Aplicacao.SetAtivo(true);
        }

        private Aplicacao Aplicacao { get; set; }

        public AplicacaoBuilder Nomeado(string nome)
        {
            Aplicacao.SetNome(nome);
            return this;
        }

        public AplicacaoBuilder Descrito(string descricao)
        {
            Aplicacao.SetDescricao(descricao);
            return this;
        }

        public AplicacaoBuilder Desativar()
        {
            Aplicacao.SetAtivo(false);
            return this;
        }

        public AplicacaoBuilder ComOsPerfis(params Perfil[] perfis)
        {
            Aplicacao.AdicionarPerfil(perfis);
            return this;
        }

        public AplicacaoBuilder ComOsContratantes(params Contratante[] contratantes)
        {
            Aplicacao.AdicionarContratante(contratantes);
            return this;
        }

        public Aplicacao Build()
        {
            return Aplicacao;
        }
    }
}