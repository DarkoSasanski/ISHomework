using System.Collections.Generic;

namespace MovieTickets.Domain.DTO
{
    public class AddToRoleDto
    {
        public string Email { get; set; }
        public string SelectedRole { get; set; }
        public List<string> Roles { get; set; }
    }
}
