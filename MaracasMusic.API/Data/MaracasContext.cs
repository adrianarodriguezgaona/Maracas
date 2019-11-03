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
                .ToTable("Genres")
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
             .ToTable("InstrumentTypes")
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
                .ToTable("Instruments")
                .HasData(
                    new Instrument { Id = 1, ProductId = 17, Name = "LPM198 Mini Tuneable Conga", InstrumentTypeId = 1, ProductTypeId = 2 },
                    new Instrument { Id = 2, ProductId = 18, Name = "Large Wooden Maracas", InstrumentTypeId = 1, ProductTypeId = 2 },
                    new Instrument { Id = 3, ProductId = 19, Name = "Vera Cruz Harp", InstrumentTypeId = 2, ProductTypeId = 2 },
                    new Instrument { Id = 4, ProductId = 20, Name = "Baja Sexto", InstrumentTypeId = 2, ProductTypeId = 2 },
                    new Instrument { Id = 5, ProductId = 21, Name = "Gewa Pan Pipe", InstrumentTypeId = 3, ProductTypeId = 2 },
                    new Instrument { Id = 6, ProductId = 22, Name = "Quena Flute", InstrumentTypeId = 3, ProductTypeId = 2 }
                    );


            modelbuilder.Entity<Score>()
                .ToTable("Scores")
                .HasData(
                    new Score { Id = 1, ProductId = 23, ArtistId = 1, ProductTypeId = 3, GenreId = 1, Name = "Whenever, wherever" },
                    new Score { Id = 2, ProductId = 24, ArtistId = 1, ProductTypeId = 3, GenreId = 1, Name = "Hips don't Lie" },
                    new Score { Id = 3, ProductId = 25, ArtistId = 2, ProductTypeId = 3, GenreId = 1, Name =  "La Camisa Negra" },
                    new Score { Id = 4, ProductId = 26, ArtistId = 2, ProductTypeId = 3, GenreId = 1, Name = "Juntos" },
                    new Score { Id = 5, ProductId = 27, ArtistId = 3, ProductTypeId = 3, GenreId = 2, Name = "Vivir mi Vida" },
                    new Score { Id = 6, ProductId = 28, ArtistId = 3, ProductTypeId = 3, GenreId = 2, Name = "Te Conozco Bien" },
                    new Score { Id = 7, ProductId = 29, ArtistId = 4, ProductTypeId = 3, GenreId = 2, Name = "Tapanco El Hueco"},
                    new Score { Id = 8, ProductId = 30, ArtistId = 4, ProductTypeId = 3, GenreId = 2, Name = "El Amor Vendra" },
                    new Score { Id = 9, ProductId = 31, ArtistId = 5, ProductTypeId = 3, GenreId = 3, Name = "Felices Los 4" },
                    new Score { Id = 10, ProductId = 32, ArtistId = 5, ProductTypeId = 3, GenreId = 3, Name = "Corazòn" },
                    new Score { Id = 11, ProductId = 33, ArtistId = 6, ProductTypeId = 3, GenreId = 3, Name =  "Andas en mi Cabeza" },
                    new Score { Id = 12, ProductId = 34, ArtistId = 6, ProductTypeId = 3, GenreId = 3, Name = "Mi Niña Bonita" },
                    new Score { Id = 13, ProductId = 35, ArtistId = 7, ProductTypeId = 3, GenreId = 4, Name = "Déjame Entrar" },
                    new Score { Id = 14, ProductId = 36, ArtistId = 7, ProductTypeId = 3, GenreId = 4, Name = "Carito" },
                    new Score { Id = 15, ProductId = 37, ArtistId = 8, ProductTypeId = 3, GenreId = 5, Name = "Suavemente" },
                    new Score { Id = 16, ProductId = 38, ArtistId = 8, ProductTypeId = 3, GenreId = 5, Name = "Pintame" }
                );

            modelbuilder.Entity<Cd>()
               .ToTable("Cds")
               .HasData(
               new Cd { Id = 1, Name = "Shakira", ProductId = 1, ArtistId = 1, GenreId = 1 },
               new Cd { Id = 2, Name= "El Dorado", ProductId = 2, ArtistId = 1, GenreId = 1 },
               new Cd { Id = 3, Name ="Mi sangre",ProductId = 3, ArtistId = 2, GenreId = 1 },
               new Cd { Id = 4, Name="Un dia normal", ProductId = 4, ArtistId = 2, GenreId = 1 },
               new Cd { Id = 5, Name="3.0", ProductId = 5, ArtistId = 3, GenreId = 2 },
               new Cd { Id = 6, Name = "Sigo siendo yo",ProductId = 6, ArtistId = 3, GenreId = 2 },
               new Cd { Id = 7, Name= "Brillantes",ProductId = 7, ArtistId = 4, GenreId = 2 },
               new Cd { Id = 8, Name = "Bonitas y hermosas",ProductId = 8, ArtistId = 4, GenreId = 2 },
               new Cd { Id = 9, Name = "11:11",ProductId = 9, ArtistId = 5, GenreId = 3 },
               new Cd { Id = 10, Name="F.A.M.E", ProductId = 10, ArtistId = 5, GenreId = 3 },
               new Cd { Id = 11, Name= "Supremo", ProductId = 11, ArtistId = 6, GenreId = 3 },
               new Cd { Id = 12, Name = "Radio universo",ProductId = 12, ArtistId = 6, GenreId = 3 },
               new Cd { Id = 13, Name= "VIVES",ProductId = 13, ArtistId = 7, GenreId = 4 },
               new Cd { Id = 14, Name= "Más + Corazón Profundo", ProductId = 14, ArtistId = 7, GenreId = 4 },
               new Cd { Id = 15, Name= "Suavemente",ProductId = 15, ArtistId = 8, GenreId = 5 },
               new Cd { Id = 16, Name= "Los Monsters",ProductId = 16, ArtistId = 8, GenreId = 5 });


            modelbuilder.Entity<Product>()
                .ToTable("Products")
                .HasData(
                    new Product { Id = 1, ProductTypeId = 1, Description = "CD (ALBUM) |1 disk |Engels|maart 2014", Price = 11, Foto = "CdShakira1" },
                    new Product { Id = 2, ProductTypeId = 1, Description = "CD (ALBUM) |1 disk |Engels|mei 2017", Price = 10, Foto = "CdShakira2" },
                    new Product { Id = 3, ProductTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|september 2004", Price = 11, Foto = "CdJuanes1" },
                    new Product { Id = 4, ProductTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|mei 2002", Price = 9, Foto = "CdJuanes1" },
                    new Product { Id = 5, ProductTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|juli 2013", Price = 11, Foto = "CdMarcA1" },
                    new Product { Id = 6, ProductTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|juli 2006 |Verzamelalbum", Price = 11, Foto = "CdMarcA2" },
                    new Product { Id = 7, ProductTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|juni 1994  |Verzamelalbum", Price = 15, Foto = "CdGrupoN1" },
                    new Product { Id = 8, ProductTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|november 2015 ", Price = 20, Foto = "CdGrupoN2" },
                    new Product { Id = 9, ProductTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|mei 2019 ", Price = 22, Foto = "CdMaluma1" },
                    new Product { Id = 10, ProductTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|mei 2018 ", Price = 22, Foto = "CdMaluma2" },
                    new Product { Id = 11, ProductTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|October 2011", Price = 20, Foto = "CdChino1" },
                    new Product { Id = 12, ProductTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|June 23, 2015", Price = 18, Foto = "CdChino2" },
                    new Product { Id = 13, ProductTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|Nov 10, 2017", Price = 18, Foto = "CdVives1" },
                    new Product { Id = 14, ProductTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|May 13, 2014", Price = 18, Foto = "CdVives2" },
                    new Product { Id = 15, ProductTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|april 1998", Price = 18, Foto = "CdElvisC1" },
                    new Product { Id = 16, ProductTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|mei 2012", Price = 20, Foto = "CdElvisC2" });


            new Product
            {
                Id = 17,
                ProductTypeId = 2,
                Price = 60,
                Description = "Finish: Natural - Siam Oak drum shell with natural head - Head: Ø 4.5' - Approx. 28 cm high - Mini Comfort Curve II Rims",
                Foto = "instrumentPerc1.jpg"
            };

            new Product
            {
                Id = 18,
                ProductTypeId = 2,
                Price = 20,
                Description = "Simple wooden percussion instrument, deliverd in pairs",
                Foto = "instrumentPerc2.jpg"
            };

            new Product
            {
                Id = 19,
                ProductTypeId = 2,
                Price = 0,
                Description = "",
                Foto = "instrumentString1.jpg"

            };

            new Product
            {
                Id = 20,
                ProductTypeId = 2,
                Price = 470,
                Description = "RoseWood back, glossy finish, hand crafted",
                Foto = "instrumentString2.jpg"
            };

            new Product
            {
                Id = 21,
                ProductTypeId = 2,
                Price = 20,
                Description = "Hand crafted, made of Bamboo, pure tuning",
                Foto = "instrumentWind1"
            };

            new Product
            {
                Id = 22,
                ProductTypeId = 2,
                Price = 45,
                Description = "Hand crafted, made of plum wood",
                Foto = "instrumentWind2"
            };

            new Product
            {
                Id = 23,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Shakira sheet music - Song: Whenever, Wherever",
                Foto = "scoreSha1.jpg"

            };

            new Product
            {
                Id = 24,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Shakira sheet music - Song: Hips don't Lie",
                Foto = "scoreSha2.jpg"


            };

            new Product
            {
                Id = 25,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Juanes sheet music - Song: La Camisa Negra",
                Foto = "scoreJua1.jpg"

            };

            new Product
            {
                Id = 26,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Juanes sheet music - Song: Juentos",
                Foto = "scoreJua2.jpg"

            };

            new Product
            {
                Id = 27,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Marc Anthony sheet music - Song: Vivir mi Vida",
                Foto = "scoreMar1.jpg"

            };

            new Product
            {
                Id = 28,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Marc Anthony sheet music - Song: Te Conozco Bien",
                Foto = "scoreMar2.jpg"

            };

            new Product
            {
                Id = 29,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Grupo Niche sheet music - Song: Tapanco El Hueco",
                Foto = "scoreGru1.jpg"


            };

            new Product
            {
                Id = 30,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Grupo Niche - Song: El Amor Vendra",
                Foto = "scoreGru2.jpg"

            };



            new Product
            {
                Id = 31,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Maluma sheet music - Song: Felices los 4",
                Foto = "scoreMal1.jpg"

            };

            new Product
            {
                Id = 32,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Maluma sheet music - Song: Corazòn",
                Foto = "scoreMal2.jpg"

            };

            new Product
            {
                Id = 33,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Chino y Nacho sheet music - Song: Andas en mi Cabeza",
                Foto = "scoreChi1.jpg"

            };

            new Product
            {
                Id = 34,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Chino y Nacho sheet music - Song: Mi Niña Bonita",
                Foto = "scoreChi2.jpg"

            };

            new Product
            {
                Id = 35,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Carlos Vives - Song: Déjame Entrar",
                Foto = "scoreCar1.jpg"

            };

            new Product
            {
                Id = 36,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Carlos Vives sheet music - Song: Carito",
                Foto = "scoreCar2.jpg"

            };

            new Product
            {
                Id = 37,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Elvis Crespo sheet music - Song: Suavemente",
                Foto = "scoreElv1.jpg"

            };

            new Product
            {
                Id = 38,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Elvis Crespo sheet music - Song: Pintame",
                Foto = "scoreElv2.jpg"

            };

        }


        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Cd> Cds { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<InstrumentType> InstrumentTypes { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Score> Score { get; set; }

       


    }


}
