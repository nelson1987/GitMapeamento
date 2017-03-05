using Ephimes.Domain.Entities;

namespace Ephimes.Domain.Interfaces.Services
{
    public interface IUsuarioService
    {
        Usuario BuscarUsuario(int idUsuario);
    }
}