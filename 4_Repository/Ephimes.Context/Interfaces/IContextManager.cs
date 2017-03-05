namespace Ephimes.Context.Interfaces
{
    public interface IContextManager<TContext>
        where TContext : IDbContext
    {
        IDbContext GetContext();
        void Finish();
    }
}