using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Claims;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTickets.Domain.Domain;
using MovieTickets.Domain.DTO;
using MovieTickets.Domain.Enum;
using MovieTickets.Service.Interfaces;

namespace MovieTickets.Web.Controllers
{
    public class MovieTicketsController : Controller
    {
        private readonly IMovieTicketService movieTicketService;
        private readonly IMovieService movieService;

        public MovieTicketsController(IMovieTicketService movieTicketService, IMovieService movieService)
        {
            this.movieTicketService = movieTicketService;
            this.movieService = movieService;
        }

        // GET: MovieTickets
        public IActionResult Index(DateTime? filter)
        {
            if (filter != null)
            {
                return View(movieTicketService.GetAllMovieTicketsByDate((DateTime)filter));
            }
            return View(movieTicketService.GetAllMovieTickets());
        }

        // GET: MovieTickets/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieTicket = movieTicketService.GetDetailsForMovieTicket((Guid)id);
            if (movieTicket == null)
            {
                return NotFound();
            }

            return View(movieTicket);
        }

        // GET: MovieTickets/Create
        public IActionResult Create()
        {
            ViewBag.Movies = movieService.GetAllMovies(); // Replace with your code to retrieve the list of movies

            return View();
        }

        // POST: MovieTickets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("TicketPrice,MovieDateTime,Id")] MovieTicket movieTicket, Guid MovieId)
        {
            if (ModelState.IsValid)
            {
                var selectedMovie = movieService.GetDetailsForMovie(MovieId);
                if (selectedMovie != null)
                {
                    movieTicket.Movie = selectedMovie;
                    movieTicketService.CreateNewMovieTicket(movieTicket);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError("Movie.Id", "Invalid movie selection.");
                }
            }

            ViewBag.Movies = movieService.GetAllMovies(); // Pass the list of movies to the view

            return View(movieTicket);
        }
        // GET: MovieTickets/Edit/5
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieTicket = movieTicketService.GetDetailsForMovieTicket((Guid)id);
            if (movieTicket == null)
            {
                return NotFound();
            }

            ViewBag.Movies = movieService.GetAllMovies();

            return View(movieTicket);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("TicketPrice,MovieDateTime,Id,Movie")] MovieTicket movieTicket, Guid movieId)
        {
            if (id != movieTicket.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                // Fetch the selected movie based on the provided movieId
                var selectedMovie = movieService.GetDetailsForMovie(movieId);
                if (selectedMovie == null)
                {
                    ModelState.AddModelError("Movie", "Invalid movie selection.");
                    ViewBag.Movies = movieService.GetAllMovies();
                    return View(movieTicket);
                }

                movieTicket.Movie = selectedMovie;

                try
                {
                    movieTicketService.UpdateExistingMovieTicket(movieTicket);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieTicketExists(movieTicket.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            ViewBag.Movies = movieService.GetAllMovies();
            return View(movieTicket);
        }

        // GET: MovieTickets/Delete/5
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieTicket = movieTicketService.GetDetailsForMovieTicket((Guid)id);
            if (movieTicket == null)
            {
                return NotFound();
            }

            return View(movieTicket);
        }

        // POST: MovieTickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            movieTicketService.DeleteMovieTicket(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult addTicketToCart(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var ticket = movieTicketService.GetShoppingCartInfo((Guid)id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult addTicketToCart(AddTicketToCartDto model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            bool res = movieTicketService.AddToShoppingCart(model, userId);
            if (res)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }


        private bool MovieTicketExists(Guid id)
        {
            return movieTicketService.GetDetailsForMovieTicket(id)!=null;
        }

        [Authorize(Roles = "Admin")]
        public FileResult ExportTickets(string genre)
        {
            List<MovieTicket> tickets = new();
            if (genre == "All")
            {
                tickets = movieTicketService.GetAllMovieTickets();
            }
            else
            {
                tickets = movieTicketService.GetAllMovieTicketsByMovieGenre((MovieGenre)Enum.Parse(typeof(MovieGenre), genre));
            }
            using (var workbook = new XLWorkbook())
            {
                IXLWorksheet worksheet = workbook.Worksheets.Add("Tickets");
                worksheet.Cell(1, 1).Value = "Ticket Id";
                worksheet.Cell(1, 2).Value = "Movie";
                worksheet.Cell(1, 3).Value = "Movie Genre";
                worksheet.Cell(1, 4).Value = "Movie Date and Time";
                worksheet.Cell(1, 5).Value = "Ticket Price";
                for (int i = 0; i < tickets.Count; i++)
                {
                    var item = tickets[i];
                    worksheet.Cell(i + 2, 1).Value = item.Id.ToString();
                    worksheet.Cell(i + 2, 2).Value = item.Movie.MovieName;
                    worksheet.Cell(i + 2, 3).Value = item.Movie.MovieGenre.ToString();
                    worksheet.Cell(i + 2, 4).Value = item.MovieDateTime.ToString();
                    worksheet.Cell(i + 2, 5).Value = item.TicketPrice;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Tickets.xlsx");
                }
            }
        }
    }
}
