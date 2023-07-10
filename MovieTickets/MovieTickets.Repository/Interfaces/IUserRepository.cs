using MovieTickets.Domain.Identity;
using System.Collections.Generic;

namespace MovieTickets.Repository.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<MovieTicketsApplicationUser> GetAll();
        MovieTicketsApplicationUser Get(string id);
        void Insert(MovieTicketsApplicationUser entity);
        void Update(MovieTicketsApplicationUser entity);
        void Delete(MovieTicketsApplicationUser entity);
    }
}
