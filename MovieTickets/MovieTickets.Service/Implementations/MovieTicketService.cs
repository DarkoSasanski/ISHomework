using MovieTickets.Domain.Domain;
using MovieTickets.Domain.DTO;
using MovieTickets.Domain.Enum;
using MovieTickets.Domain.Relations;
using MovieTickets.Repository.Interfaces;
using MovieTickets.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieTickets.Service.Implementations
{
    public class MovieTicketService : IMovieTicketService
    {
        private readonly IMovieTicketRepository ticketsRepository;
        private readonly IUserRepository userRepository;
        private readonly IRepository<TicketsInShoppingCart> tiscRepository;

        public MovieTicketService(IMovieTicketRepository ticketsRepository, IUserRepository userRepository, IRepository<TicketsInShoppingCart> tiscRepository)
        {
            this.ticketsRepository = ticketsRepository;
            this.userRepository = userRepository;
            this.tiscRepository = tiscRepository;
        }

        public bool AddToShoppingCart(AddTicketToCartDto item, string userID)
        {
            var ticket = this.GetDetailsForMovieTicket(item.MovieTicketId);
            var user = userRepository.Get(userID);
            var cart = user.UserCart;
            if (ticket != null && user != null && cart != null)
            {
                var tisc = new TicketsInShoppingCart
                {
                    MovieTicketId = ticket.Id,
                    MovieTicket = ticket,
                    UserCart = cart,
                    ShoppingCartId = cart.Id,
                    Quantity = item.Quantity
                };
                tiscRepository.Insert(tisc);
                return true;
            }
            return false;

        }

        public void CreateNewMovieTicket(MovieTicket t)
        {
            ticketsRepository.Insert(t);
        }

        public void DeleteMovieTicket(Guid id)
        {
            var ticket = this.GetDetailsForMovieTicket(id);
            ticketsRepository.Delete(ticket);
        }

        public List<MovieTicket> GetAllMovieTickets()
        {
            return ticketsRepository.GetAll().ToList();
        }

        public List<MovieTicket> GetAllMovieTicketsByDate(DateTime date)
        {
            return ticketsRepository.GetAllByDate(date).ToList();
        }

        public List<MovieTicket> GetAllMovieTicketsByMovieGenre(MovieGenre genre)
        {
            return ticketsRepository.GetAllByMovieGenre(genre).ToList();
        }

        public MovieTicket GetDetailsForMovieTicket(Guid id)
        {
            return ticketsRepository.Get(id);
        }

        public AddTicketToCartDto GetShoppingCartInfo(Guid id)
        {
            var ticket = ticketsRepository.Get(id);
            var tisc = new AddTicketToCartDto()
            {
                MovieTicket = ticket,
                MovieTicketId = ticket.Id,
                Quantity = 1
            };
            return tisc;
        }

        public void UpdateExistingMovieTicket(MovieTicket t)
        {
            ticketsRepository.Update(t);
        }
    }
}
