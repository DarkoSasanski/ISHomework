using MovieTickets.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTickets.Domain.Domain
{
    public class Movie : BaseEntity
    {
        [Required]
        public string MovieName { get; set; }
        [Required]
        public string MovieDescription { get; set; }
        [Required]
        public string MovieImage { get; set; }
        [Required]
        public double MovieRating { get; set; }
        [Required]
        [EnumDataType(typeof(MovieGenre))]
        public MovieGenre MovieGenre { get; set; }
        public virtual IEnumerable<MovieTicket> MovieTickets { get; set; }
    }

}
