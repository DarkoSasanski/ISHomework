using MovieTickets.Domain.Domain;
using MovieTickets.Domain.DTO;
using MovieTickets.Domain.Relations;
using System;

namespace MovieTickets.Service.Interfaces
{
    public interface IShoppingCartService
    {
        Order OrderNow(string userId);
        ShoppingCartDto GetShoppingCartDto(string userId);
        TicketsInShoppingCart deleteFromCart(string userId, Guid? id);
    }
}
