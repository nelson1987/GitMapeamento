using Ephimes.Domain.Entities;

namespace Ephimes.Domain.Services
{
    public class ControleUsuario
    {
        public ControleUsuario(Usuario usuario)
        {
            Usuario = usuario;
        }

        private Usuario Usuario { get; set; }

        public void AlterarPerfil(Contratante contratante, Perfil perfil)
        {
            if (contratante.Equals(Usuario.Contratante))
            {
                Usuario.AdicionarPerfil(perfil);
            }
        }
    }
}