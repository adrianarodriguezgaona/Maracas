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

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {

        }


    }


}
