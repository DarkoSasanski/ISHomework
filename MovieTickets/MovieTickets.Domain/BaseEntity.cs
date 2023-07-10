using System;
using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Domain
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
