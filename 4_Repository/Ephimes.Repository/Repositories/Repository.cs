using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Ephimes.Domain.Interfaces.Repositories;
using Microsoft.Practices.ServiceLocation;

namespace Ephimes.Repository.Repositories
{
    public class Repository<TEntity> 
        : IRepository<TEntity>, IDisposable 
        where TEntity : class
    {
        private readonly IDbContext _dbContext;
        private readonly IDbSet<TEntity> _dbSet;

        public Repository()
        {
            var contextManager =
                ServiceLocator.Current.GetInstance<IContextManager<DataContext>>()
                    as ContextManager<DataContext>;

            _dbContext = contextManager.GetContext();
            _dbSet = _dbContext.Set<TEntity>();
        }

        public TEntity Select()
        {
            throw new NotImplementedException();
        }

        public TEntity Update()
        {
            throw new NotImplementedException();
        }

        public TEntity Insert()
        {
            throw new NotImplementedException();
        }

        public TEntity Delete()
        {
            throw new NotImplementedException();
        }
        private string NomeEntidade
        {
            get { return typeof (TEntity).FullName; }
        }

        protected IDbContext Context
        {
            get { return _dbContext; }
        }

        protected IDbSet<TEntity> DbSet
        {
            get { return _dbSet; }
        }

        public virtual void Add(TEntity entity)
        {
            try
            {
                DbSet.Add(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("ErroIncluir{0}", NomeEntidade), ex);
            }
        }

        //public virtual void Delete(int id)
        //{
        //    try
        //    {
        //        var entity = Get(id);
        //        var entry = Context.Entry(entity);
        //        DbSet.Attach(entity);
        //        entry.State = EntityState.Deleted;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(string.Format("ErroDeletar{0}", NomeEntidade), ex);
        //    }
        //}
        public virtual void Delete(TEntity entity)
        {
            try
            {
                var entry = Context.Entry(entity);
                DbSet.Attach(entity);
                entry.State = EntityState.Deleted;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("ErroDeletar{0}", NomeEntidade), ex);
            }
        }

        public TEntity Get(int id)
        {
            return DbSet.Find(id);
        }

        public virtual void Update(TEntity entity)
        {
            var entry = Context.Entry(entity);
            DbSet.Attach(entity);
            entry.State = EntityState.Modified;
        }

        public virtual IEnumerable<TEntity> All(bool @readonly = false)
        {
            try
            {
                return @readonly
                    ? DbSet.AsNoTracking().ToList()
                    : DbSet.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("ErroListar", "NomeEntidade"), ex);
            }
        }

        public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, bool @readonly = false)
        {
            return @readonly
                ? DbSet.Where(predicate).AsNoTracking()
                : DbSet.Where(predicate);
        }

        //public RetornoPesquisa<TEntity> Pesquisar(Expression<Func<TEntity, bool>> filtros, int tamanhoPagina, int pagina,
        //    Func<TEntity, IComparable> ordenacao)
        //{
        //    try
        //    {
        //        var registros = DbSet.Where(filtros).AsNoTracking(); // Find(filtros);
        //        var lista = registros.AsQueryable()
        //            .Where(filtros)
        //            .OrderBy(ordenacao)
        //            .Skip(tamanhoPagina * (pagina - 1))
        //            .Take(tamanhoPagina)
        //            .ToList();
        //        return new RetornoPesquisa<TEntity>
        //        {
        //            TotalRegistros = registros.Count(),
        //            RegistrosPagina = lista,
        //            TotalPaginas = (int)Math.Ceiling(registros.Count() / (double)tamanhoPagina)
        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Erro ao buscar um destinatário por Id", ex);
        //    }
        //}

        #region Dispose

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;

            if (Context == null) return;
            Context.Dispose();
        }

        public TEntity GetAllReferences(int id)
        {
            return DbSet.Find(id);
        }

        public void Delete(List<TEntity> entity)
        {
            if (entity.Any())
                foreach (var item in entity)
                {
                    Delete(item);
                }
        }

        public void Add(List<TEntity> entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate, bool @readonly = false)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}