using MovieTickets.Domain.Domain;
using MovieTickets.Domain;
using System.Collections.Generic;
using System;

namespace MovieTickets.Repository.Interfaces
{
    public interface IOrderRepository
    {
        List<Order> getAllOrders();
        Order getOrderDetails(Guid id);
    }
}
