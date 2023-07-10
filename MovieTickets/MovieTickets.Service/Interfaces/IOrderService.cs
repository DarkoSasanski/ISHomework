using MovieTickets.Domain.Domain;
using MovieTickets.Domain;
using System.Collections.Generic;
using System;

namespace MovieTickets.Service.Interfaces
{
    public interface IOrderService
    {
        List<Order> getAllOrders();
        Order getOrderDetails(Guid id);
    }
}
