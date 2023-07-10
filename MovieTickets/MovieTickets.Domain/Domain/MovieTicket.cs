using MovieTickets.Domain.Relations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Domain.Domain
{
    public class MovieTicket : BaseEntity
    {
        [Required]
        public double TicketPrice { get; set; }
        [Required]
        public DateTime MovieDateTime { get; set; }
        public Movie Movie { get; set; }
        public virtual ICollection<TicketsInShoppingCart> TicketsInShoppingCarts { get; set; }
        public virtual ICollection<TicketsInOrder> TicketsInOrders { get; set; }
    }
}
