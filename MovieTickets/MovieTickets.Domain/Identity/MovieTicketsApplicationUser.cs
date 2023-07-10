using Microsoft.AspNetCore.Identity;
using MovieTickets.Domain.Domain;

namespace MovieTickets.Domain.Identity
{
    public class MovieTicketsApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public virtual ShoppingCart UserCart { get; set; }
    }
}
