using Maracas.Lib.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaracasMusic.API.Data
{
    public class MaracasContext : DbContext
    {

        public MaracasContext(DbContextOptions<MaracasContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {

            modelbuilder.Entity<Genre>()
                .ToTable("Genre")
                .HasData(
                new Genre
                {
                    Id = 1,
                    Name = "Pop Muziek"
                },


                new Genre
                {
                    Id = 2,
                    Name = "Salsa"
                },

                new Genre
                {
                    Id = 3,
                    Name = "Regueton"
                },

                new Genre
                {
                    Id = 4,
                    Name = "Cumbia"
                },
                  new Genre
                  {
                      Id = 5,
                      Name = "Cumbia"
                  });

            modelbuilder.Entity<Artist>()
               .ToTable("Artists")
               .HasData(
               new Artist
               {
                   Id = 1,
                   Name = "Shakira",
                   GenreId = 1
               },
               new Artist
               {
                Id = 2,
                   Name = "Juanes",
                   GenreId = 1
               },
               new Artist
               {
                   Id = 3,
                   Name = "Marc Anthony",
                   GenreId = 2
               },
                new Artist
                {
                    Id = 4,
                    Name = "Grupo Niche",
                    GenreId = 2
                },
                 new Artist
                 {
                     Id = 5,
                     Name = "Maluma",
                     GenreId = 3
                 },
                  new Artist
                  {
                      Id = 6,
                      Name = "Chino y Nacho",
                      GenreId = 3
                  },

                   new Artist
                   {
                       Id = 7,
                       Name = "Carlos Vives",
                       GenreId = 4
                   },


                   new Artist
                   {
                       Id = 8,
                       Name = "Elvis Crespo",
                       GenreId = 5
                   }
              );
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Cd> Cds { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<InstrumentType> InstrumentTypes { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Score> Scores { get; set; }

       


    }


}
