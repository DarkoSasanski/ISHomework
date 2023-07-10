using Microsoft.EntityFrameworkCore;
using MovieTickets.Domain.Domain;
using MovieTickets.Domain.Enum;
using MovieTickets.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieTickets.Repository.Implementations
{
    public class MovieTicketRepository : IMovieTicketRepository
    {
        private readonly ApplicationDbContext _context;
        private DbSet<MovieTicket> _entities;

        public MovieTicketRepository(ApplicationDbContext context)
        {
            _context = context;
            _entities = _context.Set<MovieTicket>();
        }

        public void Delete(MovieTicket entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public MovieTicket Get(Guid id)
        {
            return _entities.Include(z => z.Movie).SingleOrDefault(z => z.Id == id);
        }

        public IEnumerable<MovieTicket> GetAll()
        {
            return _entities.Include(z => z.Movie).AsEnumerable();
        }

        public IEnumerable<MovieTicket> GetAllByDate(DateTime date)
        {
            return _entities.Include(z => z.Movie).Where(z => z.MovieDateTime.Date == date.Date);
        }

        public IEnumerable<MovieTicket> GetAllByMovieGenre(MovieGenre genre)
        {
            return _entities.Include(z => z.Movie).Where(z => z.Movie.MovieGenre == genre);
        }

        public void Insert(MovieTicket entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Update(MovieTicket entity)
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
