﻿using System.Collections.Generic;
using Ephimes.Domain.Entities.Tipos;

namespace Ephimes.Domain.Entities
{
    public class Banco
    {
        private Banco()
        {
            SolicitacaoModificacaoBanco = new List<SolicitacaoModificacaoBanco>();
        }

        public Banco(string codigo, string nome) : this()
        {
            Codigo = codigo;
            Nome = nome;
        }

        public int Id { get; private set; }
        public string Codigo { get; private set; }
        public string Nome { get; private set; }
        public Empresa Contratante { get; private set; }
        public List<SolicitacaoModificacaoBanco> SolicitacaoModificacaoBanco { get; private set; }
    }
}