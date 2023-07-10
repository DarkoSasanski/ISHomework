using Microsoft.AspNetCore.Identity;
using MovieTickets.Domain.DTO;
using MovieTickets.Domain.Identity;
using MovieTickets.Repository.Interfaces;
using MovieTickets.Service.Interfaces;
using System;
using System.Collections.Generic;

namespace MovieTickets.Service.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly UserManager<MovieTicketsApplicationUser> userManager;

        public UserService(IUserRepository userRepository, UserManager<MovieTicketsApplicationUser> userManager)
        {
            this.userRepository = userRepository;
            this.userManager = userManager;
        }

        public bool addToRoleUser(String email, string selectedRole)
        {
            var user = this.getUserByEmail(email);
            if (user != null)
            {
                var existingRoles = userManager.GetRolesAsync(user).Result;
                _ = userManager.RemoveFromRolesAsync(user, existingRoles).Result;
                _ = userManager.AddToRoleAsync(user, selectedRole).Result;
                return true;
            }
            return false;
        }

        public AddToRoleDto getAddToRoleDto(MovieTicketsApplicationUser user)
        {
            AddToRoleDto model = new AddToRoleDto();
            model.Email = user.Email;
            model.Roles = new List<string>() { "Admin", "StandardUser" };
            var roles = userManager.GetRolesAsync(user).Result;
            model.SelectedRole = null;
            if (roles.Count > 0)
            {
                model.SelectedRole = roles[0];
            }
            return model;
        }

        public IEnumerable<MovieTicketsApplicationUser> getAllUsers()
        {
            return userRepository.GetAll();
        }

        public MovieTicketsApplicationUser getUserByEmail(string email)
        {
            var user = userManager.FindByEmailAsync(email).Result;
            return user;
        }
    }
}
