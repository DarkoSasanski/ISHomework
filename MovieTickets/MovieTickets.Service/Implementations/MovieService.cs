using MovieTickets.Domain.Domain;
using MovieTickets.Repository.Interfaces;
using MovieTickets.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieTickets.Service.Implementations
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<Movie> movieRepository;

        public MovieService(IRepository<Movie> movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        public void CreateNewMovie(Movie m)
        {
            movieRepository.Insert(m);
        }

        public void DeleteMovie(Guid id)
        {
            var movie = this.GetDetailsForMovie(id);
            movieRepository.Delete(movie);
        }

        public List<Movie> GetAllMovies()
        {
            return movieRepository.GetAll().ToList();
        }

        public Movie GetDetailsForMovie(Guid id)
        {
            return movieRepository.Get(id);
        }

        public void UpdateExistingMovie(Movie m)
        {
            movieRepository.Update(m);
        }
    }
}
