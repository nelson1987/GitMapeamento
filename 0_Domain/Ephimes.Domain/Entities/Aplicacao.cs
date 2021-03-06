﻿using System.Collections.Generic;
using System.Linq;

namespace Ephimes.Domain.Entities
{
    public class Aplicacao
    {
        public Aplicacao()
        {
            Perfis = new List<Perfil>();
            Contratantes = new List<Contratante>();
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public bool Ativo { get; private set; }
        public List<Contratante> Contratantes { get; private set; }
        public List<Perfil> Perfis { get; private set; }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public void SetAtivo(bool ativo)
        {
            Ativo = ativo;
        }

        public void AdicionarPerfil(Perfil perfil)
        {
            if (!TemEssePerfil(perfil))
                Perfis.Add(perfil);
        }

        public void AdicionarPerfil(params Perfil[] perfis)
        {
            foreach (var perfil in perfis)
            {
                AdicionarPerfil(perfil);
            }
        }

        public void AdicionarContratante(Contratante contratante)
        {
            Contratantes.Add(contratante);
        }

        public void AdicionarContratante(params Contratante[] contratantes)
        {
            foreach (var contratante in contratantes)
            {
                AdicionarContratante(contratante);
            }
        }

        private bool TemEssePerfil(Perfil perfil)
        {
            return Perfis.Any(x => x == perfil);
        }
    }
}