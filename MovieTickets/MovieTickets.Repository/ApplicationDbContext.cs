using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieTickets.Domain.Domain;
using MovieTickets.Domain.Identity;
using MovieTickets.Domain.Relations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTickets.Repository
{
    public class ApplicationDbContext : IdentityDbContext<MovieTicketsApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MovieTicket> MovieTickets { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<TicketsInShoppingCart> TicketsInShoppingCarts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<TicketsInOrder> TicketsInOrders { get; set; }
        public virtual DbSet<EmailMessage> EmailMessages { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<TicketsInShoppingCart>()
                .HasOne(p => p.MovieTicket)
                .WithMany(psc => psc.TicketsInShoppingCarts)
                .HasForeignKey(z => z.MovieTicketId);

            builder.Entity<TicketsInShoppingCart>()
                .HasOne(sc => sc.UserCart)
                .WithMany(psc => psc.TicketsInShoppingCarts)
                .HasForeignKey(z => z.ShoppingCartId);

            builder.Entity<MovieTicket>().Property(z => z.Id).ValueGeneratedOnAdd();

            builder.Entity<ShoppingCart>().Property(z => z.Id).ValueGeneratedOnAdd();

            builder.Entity<TicketsInOrder>()
                .HasOne(z => z.MovieTicket)
                .WithMany(z => z.TicketsInOrders)
                .HasForeignKey(z => z.MovieTicketId);

            builder.Entity<TicketsInOrder>()
                .HasOne(z => z.Order)
                .WithMany(z => z.TicketsInOrders)
                .HasForeignKey(z => z.OrderId);

            builder.Entity<Movie>()
                .HasMany(m => m.MovieTickets)
                .WithOne(c => c.Movie)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<MovieTicket>()
                .HasMany(m => m.TicketsInShoppingCarts)
                .WithOne(c => c.MovieTicket)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<MovieTicket>()
                .HasMany(m => m.TicketsInOrders)
                .WithOne(c => c.MovieTicket)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
