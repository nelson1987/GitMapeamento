using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Ephimes.Domain.Entities;

namespace Ephimes.Context.Models
{
    public class DataContexto : BaseDbContext
    {
        static DataContexto()
        {
            Database.SetInitializer<DataContexto>(null);
        }

        public DataContexto()
            : base("DataContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;

            //NotaFiscal = Set<NotaFiscal>();
            //Solicitacao = Set<Solicitacao>();

            // Log all the database calls when in Debug.
            Database.Log = message => Debug.Write(message);
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Solicitacao> Solicitacoes { get; set; }
        //public DbSet<Turma> Turmas { get; set; }
        //public DbSet<Curso> Cursos { get; set; }
        //public DbSet<Professor> Professores { get; set; }
        //public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
                throw new ArgumentNullException("modelBuilder");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //modelBuilder.HasDefaultSchema("dbecfefbeeb71b43b88adaa70c017b1fcb");
            modelBuilder.Properties()
                .Where(p => p.Name == "Id")
                .Configure(p => p.IsKey());
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));
        }
}
