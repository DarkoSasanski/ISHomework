using MovieTickets.Domain.Domain;
using MovieTickets.Domain.DTO;
using MovieTickets.Domain.Relations;
using MovieTickets.Repository.Interfaces;
using MovieTickets.Service.Interfaces;
using System;
using System.Linq;
using System.Text;

namespace MovieTickets.Service.Implementations
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IRepository<Order> ordersRepository;
        private readonly IRepository<TicketsInShoppingCart> ticsRepository;
        private readonly IUserRepository userRepository;
        private readonly IRepository<TicketsInOrder> tiosRepository;
        private readonly IRepository<ShoppingCart> cartRepository;
        private readonly IRepository<EmailMessage> emailRepository;

        public ShoppingCartService(IRepository<Order> ordersRepository, IRepository<TicketsInShoppingCart> ticsRepository, IUserRepository userRepository, IRepository<TicketsInOrder> tiosRepository, IRepository<ShoppingCart> cartRepository, IRepository<EmailMessage> emailRepository)
        {
            this.ordersRepository = ordersRepository;
            this.ticsRepository = ticsRepository;
            this.userRepository = userRepository;
            this.tiosRepository = tiosRepository;
            this.cartRepository = cartRepository;
            this.emailRepository = emailRepository;
        }

        public TicketsInShoppingCart deleteFromCart(string userId, Guid? id)
        {
            var user = userRepository.Get(userId);
            var userCart = user.UserCart;
            var ticket = ticsRepository.Get((Guid)id);
            userCart.TicketsInShoppingCarts.Remove(ticket);
            cartRepository.Update(userCart);
            return ticket;
        }

        public ShoppingCartDto GetShoppingCartDto(string userId)
        {
            var user = userRepository.Get(userId);
            var userCart = user.UserCart;
            var allTickets = userCart.TicketsInShoppingCarts.ToList();
            var prices = allTickets.Select(z => new
            {
                z.Quantity,
                z.MovieTicket.TicketPrice
            });
            double total = 0.0;
            foreach (var p in prices)
            {
                total += p.TicketPrice * p.Quantity;
            }
            return new ShoppingCartDto()
            {
                Tickets = allTickets,
                TotalPrice = total
            };
        }

        public Order OrderNow(string userId)
        {
            var user = userRepository.Get(userId);
            var userCart = user.UserCart;
            var order = new Order()
            {
                Owner = user,
                OwnerId = user.Id
            };
            ordersRepository.Insert(order);
            var email = new EmailMessage()
            {
                MailTo = user.Email,
                Subject = "Order Created",
                Status = false
            };
            var tios = userCart.TicketsInShoppingCarts.Select(z => new TicketsInOrder
            {
                Order = order,
                OrderId = order.Id,
                MovieTicket = z.MovieTicket,
                MovieTicketId = z.MovieTicketId,
                quantity = z.Quantity
            });
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("The order consists of:");
            var total = 0.0;
            int i = 1;
            foreach (var t in tios)
            {
                tiosRepository.Insert(t);
                builder.AppendLine(i + ". " + t.MovieTicket.Movie.MovieName + " " + t.MovieTicket.TicketPrice + "$, Quantity " + t.quantity);
                total += t.quantity * t.MovieTicket.TicketPrice;
                i++;
            }
            builder.AppendLine("Total: $" + total);
            email.Body = builder.ToString();
            emailRepository.Insert(email);
            userCart.TicketsInShoppingCarts.Clear();
            cartRepository.Update(userCart);
            return order;
        }
    }
}
