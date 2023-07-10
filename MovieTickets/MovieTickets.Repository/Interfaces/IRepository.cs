using MovieTickets.Domain;
using System;
using System.Collections.Generic;

namespace MovieTickets.Repository.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(Guid id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
