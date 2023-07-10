using MovieTickets.Domain.Domain;
using MovieTickets.Repository.Interfaces;
using MovieTickets.Service.Interfaces;
using System.Collections.Generic;
using System;

namespace MovieTickets.Service.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public List<Order> getAllOrders()
        {
            return orderRepository.getAllOrders();
        }

        public Order getOrderDetails(Guid id)
        {
            return orderRepository.getOrderDetails(id);
        }
    }
}
