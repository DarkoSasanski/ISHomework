using MovieTickets.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTickets.Service.Interfaces
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
        Movie GetDetailsForMovie(Guid id);
        void CreateNewMovie(Movie m);
        void UpdateExistingMovie(Movie m);
        void DeleteMovie(Guid id);

    }
}
