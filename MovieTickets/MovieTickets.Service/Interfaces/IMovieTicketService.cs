using MovieTickets.Domain.Domain;
using MovieTickets.Domain.DTO;
using MovieTickets.Domain.Enum;
using System;
using System.Collections.Generic;

namespace MovieTickets.Service.Interfaces
{
    public interface IMovieTicketService
    {
        List<MovieTicket> GetAllMovieTickets();
        List<MovieTicket> GetAllMovieTicketsByDate(DateTime date);
        List<MovieTicket> GetAllMovieTicketsByMovieGenre(MovieGenre genre);
        MovieTicket GetDetailsForMovieTicket(Guid id);
        void CreateNewMovieTicket(MovieTicket t);
        void UpdateExistingMovieTicket(MovieTicket t);
        AddTicketToCartDto GetShoppingCartInfo(Guid id);
        void DeleteMovieTicket(Guid id);
        bool AddToShoppingCart(AddTicketToCartDto item, string userID);
    }
}
