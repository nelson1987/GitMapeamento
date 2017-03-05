using System;
using Ephimes.Domain.Interfaces.Repositories;

namespace Ephimes.Repository.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public T Select()
        {
            throw new NotImplementedException();
        }

        public T Update()
        {
            throw new NotImplementedException();
        }

        public T Insert()
        {
            throw new NotImplementedException();
        }

        public T Delete()
        {
            throw new NotImplementedException();
        }
    }
}