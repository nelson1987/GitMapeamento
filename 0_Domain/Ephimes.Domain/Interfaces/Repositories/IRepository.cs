namespace Ephimes.Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {
        T Select();
        T Update();
        T Insert();
        T Delete();
    }
}