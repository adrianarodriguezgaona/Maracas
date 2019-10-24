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

            modelbuilder.Entity<InstrumentType>()
             .ToTable("InstrumentType")
             .HasData(
                 new InstrumentType { Id = 1, Name = "Percussion" },
                 new InstrumentType { Id = 2, Name = "Strings" },
                 new InstrumentType { Id = 3, Name = "Winds" }
                 );

            modelbuilder.Entity<ProductType>()
                .ToTable("ProductType")
                .HasData(
                     new ProductType { Id = 1, Type = "Cd" },
                     new ProductType { Id = 2, Type = "Instrument" },
                     new ProductType { Id = 3, Type = "Score" }
                );


            modelbuilder.Entity<Instrument>()
                .ToTable("Instrument")
                .HasData(
                    new Instrument { Id = 1, Name = "Conga", InstrumentTypeId = 1, ProductTypeId = 2 },
                    new Instrument { Id = 2, Name = "Maracas", InstrumentTypeId = 1, ProductTypeId = 2 },
                    new Instrument { Id = 3, Name = "Vera Cruz Harp", InstrumentTypeId = 2, ProductTypeId = 2 },
                    new Instrument { Id = 4, Name = "Baja Sexto", InstrumentTypeId = 2, ProductTypeId = 2 },
                    new Instrument { Id = 5, Name = "Pan Flute", InstrumentTypeId = 3, ProductTypeId = 2 },
                    new Instrument { Id = 6, Name = "Quena Flute", InstrumentTypeId = 4, ProductTypeId = 2 }
                    );


            modelbuilder.Entity<Score>()
                .ToTable("Score")
                .HasData(
                    new Score { Id = 1, ArtistId = 1, ProductTypeId = 3, GenreId = 1, Name = "Whenever, wherever" },
                    new Score { Id = 2, ArtistId = 1, ProductTypeId = 3, GenreId = 1, Name = "Hips don't Lie" },
                    new Score { Id = 3, ArtistId = 2, ProductTypeId = 3, GenreId = 1, Name =  "La Camisa Negra" },
                    new Score { Id = 4, ArtistId = 2, ProductTypeId = 3, GenreId = 1, Name = "Juntos" },
                    new Score { Id = 5, ArtistId = 3, ProductTypeId = 3, GenreId = 2, Name = "Vivir mi Vida" },
                    new Score { Id = 6, ArtistId = 3, ProductTypeId = 3, GenreId = 2, Name = "Te Conozco Bien" },
                    new Score { Id = 7, ArtistId = 4, ProductTypeId = 3, GenreId = 2, Name = "Tapanco El Hueco"},
                    new Score { Id = 8, ArtistId = 4, ProductTypeId = 3, GenreId = 2, Name = "El Amor Vendra" },
                    new Score { Id = 9, ArtistId = 5, ProductTypeId = 3, GenreId = 3, Name = "Felices Los 4" },
                    new Score { Id = 10, ArtistId = 5, ProductTypeId = 3, GenreId = 3, Name = "Corazòn" },
                    new Score { Id = 11, ArtistId = 6, ProductTypeId = 3, GenreId = 3, Name =  "Andas en mi Cabeza" },
                    new Score { Id = 12, ArtistId = 6, ProductTypeId = 3, GenreId = 3, Name = "Mi Niña Bonita" },
                    new Score { Id = 13, ArtistId = 7, ProductTypeId = 3, GenreId = 4, Name = "Déjame Entrar" },
                    new Score { Id = 14, ArtistId = 7, ProductTypeId = 3, GenreId = 4, Name = "Carito" },
                    new Score { Id = 15, ArtistId = 8, ProductTypeId = 3, GenreId = 5, Name = "Suavemente" },
                    new Score { Id = 16, ArtistId = 8, ProductTypeId = 3, GenreId = 5, Name = "Pintame" }
                );

            modelbuilder.Entity<Cd>()
               .ToTable("Cds")
               .HasData(
               new Cd { Id = 1, ProductId = 1, ArtistId = 1, GenreId = 1 },
               new Cd { Id = 2, ProductId = 2, ArtistId = 1, GenreId = 1 },
               new Cd { Id = 3, ProductId = 3, ArtistId = 2, GenreId = 1 },
               new Cd { Id = 4, ProductId = 4, ArtistId = 2, GenreId = 1 },
               new Cd { Id = 5, ProductId = 5, ArtistId = 3, GenreId = 2 },
               new Cd { Id = 6, ProductId = 6, ArtistId = 3, GenreId = 2 },
               new Cd { Id = 7, ProductId = 7, ArtistId = 4, GenreId = 2 },
               new Cd { Id = 8, ProductId = 8, ArtistId = 4, GenreId = 2 },
               new Cd { Id = 9, ProductId = 9, ArtistId = 5, GenreId = 3 },
               new Cd { Id = 10, ProductId = 10, ArtistId = 5, GenreId = 3 },
               new Cd { Id = 11, ProductId = 11, ArtistId = 6, GenreId = 3 },
               new Cd { Id = 12, ProductId = 12, ArtistId = 6, GenreId = 3 },
               new Cd { Id = 13, ProductId = 13, ArtistId = 7, GenreId = 4 },
               new Cd { Id = 14, ProductId = 14, ArtistId = 7, GenreId = 4 },
               new Cd { Id = 15, ProductId = 15, ArtistId = 8, GenreId = 5 },
               new Cd { Id = 16, ProductId = 16, ArtistId = 8, GenreId = 5 });

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
