using MovieTickets.Domain.DTO;
using MovieTickets.Domain.Identity;
using System.Collections.Generic;

namespace MovieTickets.Service.Interfaces
{
    public interface IUserService
    {
        IEnumerable<MovieTicketsApplicationUser> getAllUsers();
        MovieTicketsApplicationUser getUserByEmail(string email);
        AddToRoleDto getAddToRoleDto(MovieTicketsApplicationUser user);
        bool addToRoleUser(string email, string selectedRole);
    }
}
