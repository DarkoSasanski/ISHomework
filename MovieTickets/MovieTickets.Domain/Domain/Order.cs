using MovieTickets.Domain.Identity;
using MovieTickets.Domain.Relations;
using System.Collections.Generic;

namespace MovieTickets.Domain.Domain
{
    public class Order : BaseEntity
    {
        public string OwnerId { get; set; }
        public virtual MovieTicketsApplicationUser Owner { get; set; }
        public virtual ICollection<TicketsInOrder> TicketsInOrders { get; set; }
    }
}
