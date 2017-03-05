using System;
using Ephimes.Domain.Entities;
using Ephimes.Domain.Interfaces.Repositories;
using Ephimes.Domain.Interfaces.Services;

namespace Ephimes.Domain.Services
{
    public class UsuarioService : IUsuarioService
    {
        public UsuarioService(IUsuarioRepository repository)
        {
            Repository = repository;
        }

        public IUsuarioRepository Repository { get; private set; }

        public Usuario BuscarUsuario(int idUsuario)
        {
            try
            {
                //var nota = Repository.GetById(idNotaFiscal);
                //nota.DarBaixa();
                //Repository.Update(nota);
                return new Usuario("");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}