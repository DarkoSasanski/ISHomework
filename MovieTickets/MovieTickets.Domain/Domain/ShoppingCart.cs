using MovieTickets.Domain.Identity;
using MovieTickets.Domain.Relations;
using System;
using System.Collections.Generic;

namespace MovieTickets.Domain.Domain
{
    public class ShoppingCart : BaseEntity
    {
        public String OwnerId { get; set; }
        public virtual MovieTicketsApplicationUser Owner { get; set; }
        public virtual ICollection<TicketsInShoppingCart> TicketsInShoppingCarts { get; set; }
    }
}
