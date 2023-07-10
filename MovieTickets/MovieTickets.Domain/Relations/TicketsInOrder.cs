using MovieTickets.Domain.Domain;
using System;

namespace MovieTickets.Domain.Relations
{
    public class TicketsInOrder : BaseEntity
    {
        public Guid MovieTicketId { get; set; }
        public virtual MovieTicket MovieTicket { get; set; }
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int quantity { get; set; }
    }
}
