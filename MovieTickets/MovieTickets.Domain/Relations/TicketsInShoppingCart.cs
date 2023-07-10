using MovieTickets.Domain.Domain;
using System;

namespace MovieTickets.Domain.Relations
{
    public class TicketsInShoppingCart : BaseEntity
    {
        public Guid MovieTicketId { get; set; }
        public virtual MovieTicket MovieTicket { get; set; }
        public Guid ShoppingCartId { get; set; }
        public virtual ShoppingCart UserCart { get; set; }
        public int Quantity { get; set; }
    }
}
