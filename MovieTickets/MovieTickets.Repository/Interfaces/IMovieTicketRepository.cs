using MovieTickets.Domain.Domain;
using MovieTickets.Domain.Enum;
using System;
using System.Collections.Generic;

namespace MovieTickets.Repository.Interfaces
{
    public interface IMovieTicketRepository
    {
        IEnumerable<MovieTicket> GetAll();
        IEnumerable<MovieTicket> GetAllByDate(DateTime date);
        IEnumerable<MovieTicket> GetAllByMovieGenre(MovieGenre genre);

        MovieTicket Get(Guid id);
        void Insert(MovieTicket entity);
        void Update(MovieTicket entity);
        void Delete(MovieTicket entity);
    }
}
