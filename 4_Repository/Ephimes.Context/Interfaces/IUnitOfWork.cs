namespace Ephimes.Context.Interfaces
{
    public interface IUnitOfWork<TContext>
        where TContext : IDbContext
    {
        void BeginTransaction();
        void SaveChanges();
    }
}