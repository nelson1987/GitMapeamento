using Ephimes.Domain.Entities;

namespace Ephimes.Domain.Services
{
    public class IncluirContratanteService
    {
        public IncluirContratanteService(Usuario usuario, Contratante contratante)
        {
            //contratante.SetCriador(usuario);
            //contratante.TipoEmpresa;
        }

        public Usuario Usuario { get; private set; }
        public Contratante Contratante { get; private set; }
    }
}