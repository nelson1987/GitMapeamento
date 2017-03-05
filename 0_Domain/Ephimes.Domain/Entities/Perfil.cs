﻿using System.Collections.Generic;

namespace Ephimes.Domain.Entities
{
    public class Perfil
    {
        protected Perfil()
        {
        }

        public Perfil(string nome) : this()
        {
            Nome = nome;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public List<Usuario> Usuarios { get; private set; }
        public Contratante Contratante { get; private set; }
    }
}