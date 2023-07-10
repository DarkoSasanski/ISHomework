using MovieTickets.Domain.Domain;
using System;
using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Domain.DTO
{
    public class AddTicketToCartDto
    {
        [Required]
        public Guid MovieTicketId { get; set; }
        public MovieTicket MovieTicket { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
