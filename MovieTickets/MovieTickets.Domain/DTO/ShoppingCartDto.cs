using MovieTickets.Domain.Relations;
using System.Collections.Generic;

namespace MovieTickets.Domain.DTO
{
    public class ShoppingCartDto
    {
        public List<TicketsInShoppingCart> Tickets { get; set; }
        public double TotalPrice { get; set; }
    }
}
