using Maracas.Lib.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaracasMusic.API.Data
{
    public class preset : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           


            modelBuilder.Entity<InstrumentType>()
                .ToTable("InstrumentType")
                .HasData(
                    new InstrumentType { Id = 1, Name = "Percussion" },
                    new InstrumentType { Id = 2, Name = "Strings" },
                    new InstrumentType { Id = 3, Name = "Winds" }
                    );

            modelBuilder.Entity<ProductType>()
                .ToTable("ProductType")
                .HasData(
                     new ProductType { Id = 1, Type = "Cd" },
                     new ProductType { Id = 2, Type = "Instrument" },
                     new ProductType { Id = 3, Type = "Score" }
                );


            modelBuilder.Entity<Instrument>()
                .ToTable("Instrument")
                .HasData(
                    new Instrument { Id = 1, Name = "Conga", InstrumentTypeId = 1, ProductTypeId = 2 },
                    new Instrument { Id = 2, Name = "Pandeiro", InstrumentTypeId = 1, ProductTypeId = 2 },
                    new Instrument { Id = 3, Name = "Vera Cruz Harp", InstrumentTypeId = 2, ProductTypeId = 2 },
                    new Instrument { Id = 4, Name = "Baja Sexto", InstrumentTypeId = 2, ProductTypeId = 2 },
                    new Instrument { Id = 5, Name = "Pan Flute", InstrumentTypeId = 3, ProductTypeId = 2 },
                    new Instrument { Id = 6, Name = "Quena Flute", InstrumentTypeId = 4, ProductTypeId = 2 }
                    );


            modelBuilder.Entity<Score>()
                .ToTable("Score")
                .HasData(
                    new Score { Id = 1, ArtistId = 1, ProductTypeId = 3 },
                    new Score { Id = 2, ArtistId = 1, ProductTypeId = 3 },
                    new Score { Id = 3, ArtistId = 2, ProductTypeId = 3 },
                    new Score { Id = 4, ArtistId = 2, ProductTypeId = 3 },
                    new Score { Id = 5, ArtistId = 3, ProductTypeId = 3 },
                    new Score { Id = 6, ArtistId = 3, ProductTypeId = 3 },
                    new Score { Id = 7, ArtistId = 4, ProductTypeId = 3 },
                    new Score { Id = 8, ArtistId = 4, ProductTypeId = 3 },
                    new Score { Id = 9, ArtistId = 5, ProductTypeId = 3 },
                    new Score { Id = 10, ArtistId = 5, ProductTypeId = 3 },
                    new Score { Id = 11, ArtistId = 6, ProductTypeId = 3 },
                    new Score { Id = 12, ArtistId = 6, ProductTypeId = 3 },
                    new Score { Id = 13, ArtistId = 7, ProductTypeId = 3 },
                    new Score { Id = 14, ArtistId = 7, ProductTypeId = 3 },
                    new Score { Id = 15, ArtistId = 8, ProductTypeId = 3 },
                    new Score { Id = 16, ArtistId = 8, ProductTypeId = 3 }
                );

                
        }

       
    }
}
