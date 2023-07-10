using Microsoft.EntityFrameworkCore;
using MovieTickets.Domain.Domain;
using MovieTickets.Repository.Interfaces;
using System.Collections.Generic;
using System;

namespace MovieTickets.Repository.Implementations
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Order> entities;

        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
            entities = context.Set<Order>();
        }

        public List<Order> getAllOrders()
        {
            return entities.Include(z => z.Owner)
                .Include(z => z.TicketsInOrders)
                .Include("TicketsInOrders.MovieTicket")
                .Include("TicketsInOrders.MovieTicket.Movie")
                .ToListAsync().Result;
        }

        public Order getOrderDetails(Guid id)
        {
            return entities.Include(z => z.Owner)
               .Include(z => z.TicketsInOrders)
               .Include("TicketsInOrders.MovieTicket")
               .Include("TicketsInOrders.MovieTicket.Movie")
               .SingleOrDefaultAsync(z => z.Id == id).Result;
        }
    }
}
