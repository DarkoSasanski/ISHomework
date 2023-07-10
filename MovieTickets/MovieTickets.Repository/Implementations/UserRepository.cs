using Microsoft.EntityFrameworkCore;
using MovieTickets.Domain.Identity;
using MovieTickets.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieTickets.Repository.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private DbSet<MovieTicketsApplicationUser> entities;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
            entities = _context.Set<MovieTicketsApplicationUser>();

        }

        public void Delete(MovieTicketsApplicationUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public MovieTicketsApplicationUser Get(string id)
        {
            return entities.
                Include(z => z.UserCart).
                Include("UserCart.TicketsInShoppingCarts")
                .Include("UserCart.TicketsInShoppingCarts.MovieTicket")
                .Include("UserCart.TicketsInShoppingCarts.MovieTicket.Movie")
                .SingleOrDefault(z => z.Id == id);
        }

        public IEnumerable<MovieTicketsApplicationUser> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(MovieTicketsApplicationUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Update(MovieTicketsApplicationUser entity)
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
