using Microsoft.EntityFrameworkCore;
using MovieTickets.Domain;
using MovieTickets.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieTickets.Repository.Implementations
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private DbSet<T> entities;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            entities = context.Set<T>();

        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public T Get(Guid id)
        {
            return entities.SingleOrDefault(z => z.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
