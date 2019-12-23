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
                       Name = "Geen genre"
                   },

                new Genre
                {
                    Id = 2,
                    Name = "Pop Muziek"
                },


                new Genre
                {
                    Id = 3,
                    Name = "Salsa"
                },

                new Genre
                {
                    Id = 4,
                    Name = "Regueton"
                },

                new Genre
                {
                    Id = 5,
                    Name = "Cumbia"
                },
                  new Genre
                  {
                      Id = 6,
                      Name = "Merengue"
                  });

            modelbuilder.Entity<Artist>()
               .ToTable("Artists")
               .HasData(

                 new Artist
                 {
                     Id = 1,
                     Name = "Geen artiest",
                     GenreId = 1
                 },

                new Artist
               {
                   Id = 2,
                   Name = "Shakira",
                   GenreId = 2
               },
               new Artist
               {
                Id = 3,
                   Name = "Juanes",
                   GenreId = 2
               },
               new Artist
               {
                   Id = 4,
                   Name = "Marc Anthony",
                   GenreId = 3
               },
                new Artist
                {
                    Id = 5,
                    Name = "Grupo Niche",
                    GenreId = 3
                },
                 new Artist
                 {
                     Id = 6,
                     Name = "Maluma",
                     GenreId = 4
                 },
                  new Artist
                  {
                      Id = 7,
                      Name = "Chino y Nacho",
                      GenreId = 4
                  },

                   new Artist
                   {
                       Id = 8,
                       Name = "Carlos Vives",
                       GenreId = 5
                   },


                   new Artist
                   {
                       Id = 9,
                       Name = "Elvis Crespo",
                       GenreId = 6
                   }
              );

            modelbuilder.Entity<InstrumentType>()
             .ToTable("InstrumentTypes")
             .HasData(

                new InstrumentType { Id = 1, Name = "Geen instrumentType" },
                new InstrumentType { Id = 2, Name = "Percussion" },
                 new InstrumentType { Id = 3, Name = "Strings" },
                 new InstrumentType { Id = 4, Name = "Winds" }
                 );

            modelbuilder.Entity<ProductType>()
                .ToTable("ProductTypes")
                .HasData(
                     new ProductType { Id = 1, Name = "Cd" },
                     new ProductType { Id = 2, Name = "Instrument" },
                     new ProductType { Id = 3, Name = "Score" }
                );



            modelbuilder.Entity<Product>()
                .ToTable("Products")
                .HasData(
                    new Product { Id = 1, Name = "Shakira", ProductTypeId = 1, ArtistId = 2, GenreId = 2, InstrumentTypeId = 1,  Description = "CD (ALBUM) |1 disk |Engels|maart 2014", Price = 11, Foto = "CdShakira1.jpg" },
                    new Product { Id = 2, Name = "El Dorado", ProductTypeId = 1, ArtistId = 2, GenreId = 2, InstrumentTypeId = 1, Description = "CD (ALBUM) |1 disk |Engels|mei 2017", Price = 10, Foto = "CdShakira2.jpg" },
                    new Product { Id = 3, Name = "Mi sangre", ProductTypeId = 1, ArtistId = 3, GenreId = 2, InstrumentTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|september 2004", Price = 11, Foto = "CdJuanes1.jpg" },
                    new Product { Id = 4, Name = "Un dia normal", ProductTypeId = 1, ArtistId = 3, GenreId = 2, InstrumentTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|mei 2002", Price = 9, Foto = "CdJuanes2.jpg" },
                    new Product { Id = 5, Name = "3.0", ProductTypeId = 1, ArtistId = 4, GenreId = 3, InstrumentTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|juli 2013", Price = 11, Foto = "CdMarcA1.jpg" },
                    new Product { Id = 6, Name = "Sigo siendo yo", ProductTypeId = 1, ArtistId = 4, GenreId = 3, InstrumentTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|juli 2006 |Verzamelalbum", Price = 11, Foto = "CdMarcA2.jpg" },
                    new Product { Id = 7, Name = "Brillantes", ProductTypeId = 1, ArtistId = 5, GenreId = 3, InstrumentTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|juni 1994  |Verzamelalbum", Price = 15, Foto = "CdGrupoN1.jpg" },
                    new Product { Id = 8, Name = "Bonitas y hermosas", ProductTypeId = 1, ArtistId = 5, GenreId = 3, InstrumentTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|november 2015 ", Price = 20, Foto = "CdGrupoN2.jpg" },
                    new Product { Id = 9, Name = "11:11", ProductTypeId = 1, ArtistId = 6, GenreId = 4, InstrumentTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|mei 2019 ", Price = 22, Foto = "CdMaluma1.jpg" },
                    new Product { Id = 10, Name = "F.A.M.E", ProductTypeId = 1, ArtistId = 6, GenreId = 4, InstrumentTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|mei 2018 ", Price = 22, Foto = "CdMaluma2.jpg" },
                    new Product { Id = 11, Name = "Supremo", ProductTypeId = 1, ArtistId = 7, GenreId = 4, InstrumentTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|October 2011", Price = 20, Foto = "CdChino1.jpg" },
                    new Product { Id = 12, Name = "Radio universo", ProductTypeId = 1, ArtistId = 7, GenreId = 4, InstrumentTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|June 23, 2015", Price = 18, Foto = "CdChino2.jpg" },
                    new Product { Id = 13, Name = "VIVES", ProductTypeId = 1, ArtistId = 8, GenreId = 5, InstrumentTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|Nov 10, 2017", Price = 18, Foto = "CdVives1.jpg" },
                    new Product { Id = 14, Name = "Más + Corazón Profundo", ProductTypeId = 1, ArtistId = 8, GenreId = 5, InstrumentTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|May 13, 2014", Price = 18, Foto = "CdVives2.jpg" },
                    new Product { Id = 15, Name = "Suavemente", ProductTypeId = 1, ArtistId = 9, GenreId = 6, InstrumentTypeId = 1,  Description = "CD (ALBUM) |1 disk |Spaans|april 1998", Price = 18, Foto = "CdElvisC1.jpg" },
                    new Product { Id = 16, Name = "Los Monsters", ProductTypeId = 1, ArtistId = 9, GenreId = 6, InstrumentTypeId = 1, Description = "CD (ALBUM) |1 disk |Spaans|mei 2012", Price = 20, Foto = "CdElvisC2.jpg" },


            new Product
            {
                Id = 17,
                ProductTypeId = 2,
                Name = "LPM198 Mini Tuneable Conga",
                ArtistId = 1,
                GenreId = 1,
                InstrumentTypeId = 2,
                Price = 60,
                Description = "Finish: Natural - Siam Oak drum shell with natural head - Head: Ø 4.5' - Approx. 28 cm high - Mini Comfort Curve II Rims",
                Foto = "instrumentPerc1.jpg"
            },

            new Product
            {
                Id = 18,
                ProductTypeId = 2,
                Name = "Large Wooden Maracas",
                ArtistId = 1,
                GenreId = 1,
                InstrumentTypeId = 2,
                Price = 20,
                Description = "Simple wooden percussion instrument, deliverd in pairs",
                Foto = "instrumentPerc2.jpg"
            },

            new Product
            {
                Id = 19,
                ProductTypeId = 2,
                Name = "Vera Cruz Harp",
                ArtistId = 1,
                GenreId = 1,
                InstrumentTypeId = 3,
                Price = 50,
                Description = "",
                Foto = "instrumentString1.jpg"

            },

            new Product
            {
                Id = 20,
                ProductTypeId = 2,
                Name = "Baja Sexto",
                ArtistId = 1,
                GenreId = 1,
                InstrumentTypeId = 3,
                Price = 470,
                Description = "RoseWood back, glossy finish, hand crafted",
                Foto = "instrumentString2.jpg"
            },

            new Product
            {
                Id = 21,
                ProductTypeId = 2,
                Name = "Gewa Pan Pipe",
                ArtistId = 1,
                GenreId = 1,
                InstrumentTypeId = 4,
                Price = 20,
                Description = "Hand crafted, made of Bamboo, pure tuning",
                Foto = "instrumentWind1"
            },


            new Product
            {
                Id = 22,
                ProductTypeId = 2,
                Name = "Quena Flute",
                ArtistId = 1,
                GenreId = 1,
                InstrumentTypeId = 4,
                Price = 45,
                Description = "Hand crafted, made of plum wood",
                Foto = "instrumentWind2"
            },

            new Product
            {
                Id = 23,
                ProductTypeId = 3,
                Name = "Whenever, wherever",
                ArtistId = 2,
                GenreId = 2,
                InstrumentTypeId = 1,
                Price = 9.99m,
                Description = "Shakira sheet music - Song: Whenever, Wherever",
                Foto = "scoreSha1.jpg"

            },

            new Product
            {
                Id = 24,
                ProductTypeId = 3,
                Name = "Hips don't Lie",
                ArtistId = 2,
                GenreId = 2,
                InstrumentTypeId = 1,
                Price = 9.99m,
                Description = "Shakira sheet music - Song: Hips don't Lie",
                Foto = "scoreSha2.jpg"


            },

            new Product
            {
                Id = 25,
                ProductTypeId = 3,
                Name = "La Camisa Negra",
                ArtistId = 3,
                GenreId = 2,
                InstrumentTypeId = 1,
                Price = 9.99m,
                Description = "Juanes sheet music - Song: La Camisa Negra",
                Foto = "scoreJua1.jpg"

            },

            new Product
            {
                Id = 26,
                ProductTypeId = 3,
                Name = "Juntos",
                ArtistId = 3,
                GenreId = 2,
                InstrumentTypeId = 1,
                Price = 9.99m,
                Description = "Juanes sheet music - Song: Juntos",
                Foto = "scoreJua2.jpg"

            },

            new Product
            {
                Id = 27,
                ProductTypeId = 3,
                Name = "Vivir mi Vida",
                ArtistId = 4,
                GenreId = 3,
                InstrumentTypeId = 1,
                Price = 9.99m,
                Description = "Marc Anthony sheet music - Song: Vivir mi Vida",
                Foto = "scoreMar1.jpg"

            },

            new Product
            {
                Id = 28,
                ProductTypeId = 3,
                Name = "Te Conozco Bien",
                ArtistId = 4,
                GenreId = 3,
                InstrumentTypeId = 1,
                Price = 9.99m,
                Description = "Marc Anthony sheet music - Song: Te Conozco Bien",
                Foto = "scoreMar2.jpg"

            },

            new Product
            {
                Id = 29,
                ProductTypeId = 3,
                Name = "Tapanco El Hueco",
                ArtistId = 5,
                GenreId = 3,
                InstrumentTypeId = 1,
                Price = 9.99m,
                Description = "Grupo Niche sheet music - Song: Tapanco El Hueco",
                Foto = "scoreGru1.jpg"


            },

            new Product
            {
                Id = 30,
                ProductTypeId = 3,
                Name = "El Amor Vendra",
                ArtistId = 5,
                GenreId = 3,
                InstrumentTypeId = 1,
                Price = 9.99m,
                Description = "Grupo Niche - Song: El Amor Vendra",
                Foto = "scoreGru2.jpg"

            },



            new Product
            {
                Id = 31,
                ProductTypeId = 3,
                Name = "Felices Los 4",
                ArtistId = 6,
                GenreId = 4,
                InstrumentTypeId = 1,
                Price = 9.99m,
                Description = "Maluma sheet music - Song: Felices los 4",
                Foto = "scoreMal1.jpg"

            },

            new Product
            {
                Id = 32,
                ProductTypeId = 3,
                Name = "Corazòn",
                ArtistId = 6,
                GenreId = 4,
                InstrumentTypeId = 1,
                Price = 9.99m,
                Description = "Maluma sheet music - Song: Corazòn",
                Foto = "scoreMal2.jpg"

            },

            new Product
            {
                Id = 33,
                ProductTypeId = 3,
                Name = "Andas en mi Cabeza",
                ArtistId = 7,
                GenreId = 4,
                InstrumentTypeId = 1,
                Price = 9.99m,
                Description = "Chino y Nacho sheet music - Song: Andas en mi Cabeza",
                Foto = "scoreChi1.jpg"


            },

            new Product
            {
                Id = 34,
                ProductTypeId = 3,
                Name = "Mi Niña Bonita",
                ArtistId = 7,
                GenreId = 4,
                InstrumentTypeId = 1,
                Price = 9.99m,
                Description = "Chino y Nacho sheet music - Song: Mi Niña Bonita",
                Foto = "scoreChi2.jpg"

            },

            new Product
            {
                Id = 35,
                ProductTypeId = 3,
                Name = "Déjame Entrar",
                ArtistId = 8,
                GenreId = 5,
                InstrumentTypeId = 1,
                Price = 9.99m,
                Description = "Carlos Vives - Song: Déjame Entrar",
                Foto = "scoreCar1.jpg"

            },

            new Product
            {
                Id = 36,
                ProductTypeId = 3,
                Name = "Carito",
                ArtistId = 8,
                GenreId = 5,
                InstrumentTypeId = 1,
                Price = 9.99m,
                Description = "Carlos Vives sheet music - Song: Carito",
                Foto = "scoreCar2.jpg"

            },

            new Product
            {
                Id = 37,
                ProductTypeId = 3,
                Name = "Suavemente",
                ArtistId = 9,
                GenreId = 6,
                InstrumentTypeId = 1,
                Price = 9.99m,
                Description = "Elvis Crespo sheet music - Song: Suavemente",
                Foto = "scoreElv1.jpg"

            },

            new Product
            {
                Id = 38,
                ProductTypeId = 3,
                Name = "Pintame",
                ArtistId = 9,
                GenreId = 6,
                InstrumentTypeId = 1,
                Price = 9.99m,
                Description = "Elvis Crespo sheet music - Song: Pintame",
                Foto = "scoreElv2.jpg"

            });



           
        }


        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<InstrumentType> InstrumentTypes { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }

    }

}
