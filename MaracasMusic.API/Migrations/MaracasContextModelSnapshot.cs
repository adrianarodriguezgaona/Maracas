﻿// <auto-generated />
using System;
using MaracasMusic.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MaracasMusic.API.Migrations
{
    [DbContext(typeof(MaracasContext))]
    partial class MaracasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Maracas.Lib.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GenreId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GenreId = 1,
                            Name = "Geen artiest"
                        },
                        new
                        {
                            Id = 2,
                            GenreId = 2,
                            Name = "Shakira"
                        },
                        new
                        {
                            Id = 3,
                            GenreId = 2,
                            Name = "Juanes"
                        },
                        new
                        {
                            Id = 4,
                            GenreId = 3,
                            Name = "Marc Anthony"
                        },
                        new
                        {
                            Id = 5,
                            GenreId = 3,
                            Name = "Grupo Niche"
                        },
                        new
                        {
                            Id = 6,
                            GenreId = 4,
                            Name = "Maluma"
                        },
                        new
                        {
                            Id = 7,
                            GenreId = 4,
                            Name = "Chino y Nacho"
                        },
                        new
                        {
                            Id = 8,
                            GenreId = 5,
                            Name = "Carlos Vives"
                        },
                        new
                        {
                            Id = 9,
                            GenreId = 6,
                            Name = "Elvis Crespo"
                        });
                });

            modelBuilder.Entity("Maracas.Lib.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Maracas.Lib.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Geen genre"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Pop Muziek"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Salsa"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Regueton"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Cumbia"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Merengue"
                        });
                });

            modelBuilder.Entity("Maracas.Lib.Models.InstrumentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("InstrumentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Geen instrumentType"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Percussion"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Strings"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Winds"
                        });
                });

            modelBuilder.Entity("Maracas.Lib.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<DateTime>("DateOrder");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Maracas.Lib.Models.OrderDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Aantal");

                    b.Property<string>("Name");

                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Maracas.Lib.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistId");

                    b.Property<string>("Description");

                    b.Property<string>("Foto");

                    b.Property<int?>("GenreId");

                    b.Property<int>("InstrumentTypeId");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<int>("ProductTypeId");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("GenreId");

                    b.HasIndex("InstrumentTypeId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistId = 2,
                            Description = "CD (ALBUM) |1 disk |Engels|maart 2014 -- Shakira",
                            Foto = "CdShakira1.jpg",
                            GenreId = 2,
                            InstrumentTypeId = 1,
                            Name = "El Dorado",
                            Price = 11m,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            ArtistId = 2,
                            Description = "CD (ALBUM) |1 disk |Engels|mei 2017 -- Shakira",
                            Foto = "CdShakira2.jpg",
                            GenreId = 2,
                            InstrumentTypeId = 1,
                            Name = "Shakira",
                            Price = 10m,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 3,
                            ArtistId = 3,
                            Description = "CD (ALBUM) |1 disk |Spaans|september 2004 -- Juanes",
                            Foto = "CdJuanes1.jpg",
                            GenreId = 2,
                            InstrumentTypeId = 1,
                            Name = "Mi sangre",
                            Price = 11m,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 4,
                            ArtistId = 3,
                            Description = "CD (ALBUM) |1 disk |Spaans|mei 2002 -- Juanes",
                            Foto = "CdJuanes2.jpg",
                            GenreId = 2,
                            InstrumentTypeId = 1,
                            Name = "Un dia normal",
                            Price = 9m,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 5,
                            ArtistId = 4,
                            Description = "CD (ALBUM) |1 disk |Spaans|juli 2013 -- Marc Anthony",
                            Foto = "CdMarcA1.jpg",
                            GenreId = 3,
                            InstrumentTypeId = 1,
                            Name = "3.0",
                            Price = 11m,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 6,
                            ArtistId = 4,
                            Description = "CD (ALBUM) |1 disk |Spaans|juli 2006 |Verzamelalbum -- Marc Anthony",
                            Foto = "CdMarcA2.jpg",
                            GenreId = 3,
                            InstrumentTypeId = 1,
                            Name = "Sigo siendo yo",
                            Price = 11m,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 7,
                            ArtistId = 5,
                            Description = "CD (ALBUM) |1 disk |Spaans|juni 1994  |Verzamelalbum -- Grupo Niche",
                            Foto = "CdGrupoN1.jpg",
                            GenreId = 3,
                            InstrumentTypeId = 1,
                            Name = "Brillantes",
                            Price = 15m,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 8,
                            ArtistId = 5,
                            Description = "CD (ALBUM) |1 disk |Spaans|november 2015 -- Grupo Niche ",
                            Foto = "CdGrupoN2.jpg",
                            GenreId = 3,
                            InstrumentTypeId = 1,
                            Name = "Bonitas y hermosas",
                            Price = 20m,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 9,
                            ArtistId = 6,
                            Description = "CD (ALBUM) |1 disk |Spaans|mei 2019 -- Maluma",
                            Foto = "CdMaluma1.jpg",
                            GenreId = 4,
                            InstrumentTypeId = 1,
                            Name = "11:11",
                            Price = 22m,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 10,
                            ArtistId = 6,
                            Description = "CD (ALBUM) |1 disk |Spaans|mei 2018 -- Maluma",
                            Foto = "CdMaluma2.jpg",
                            GenreId = 4,
                            InstrumentTypeId = 1,
                            Name = "F.A.M.E",
                            Price = 22m,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 11,
                            ArtistId = 7,
                            Description = "CD (ALBUM) |1 disk |Spaans|October 2011 -- Chino y Nacho",
                            Foto = "CdChino1.jpg",
                            GenreId = 4,
                            InstrumentTypeId = 1,
                            Name = "Supremo",
                            Price = 20m,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 12,
                            ArtistId = 7,
                            Description = "CD (ALBUM) |1 disk |Spaans|June 23, 2015 -- Chino y Nacho",
                            Foto = "CdChino2.jpg",
                            GenreId = 4,
                            InstrumentTypeId = 1,
                            Name = "Radio universo",
                            Price = 18m,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 13,
                            ArtistId = 8,
                            Description = "CD (ALBUM) |1 disk |Spaans|Nov 10, 2017 -- Carlos Vives",
                            Foto = "CdVives1.jpg",
                            GenreId = 5,
                            InstrumentTypeId = 1,
                            Name = "VIVES",
                            Price = 18m,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 14,
                            ArtistId = 8,
                            Description = "CD (ALBUM) |1 disk |Spaans|May 13, 2014 -- Carlos Vives",
                            Foto = "CdVives2.jpg",
                            GenreId = 5,
                            InstrumentTypeId = 1,
                            Name = "Más + Corazón Profundo",
                            Price = 18m,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 15,
                            ArtistId = 9,
                            Description = "CD (ALBUM) |1 disk |Spaans|april 1998 -- Elvis Crespo",
                            Foto = "CdElvis1.jpg",
                            GenreId = 6,
                            InstrumentTypeId = 1,
                            Name = "Suavemente",
                            Price = 18m,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 16,
                            ArtistId = 9,
                            Description = "CD (ALBUM) |1 disk |Spaans|mei 2012 -- Elvis Crespo",
                            Foto = "CdElvis2.jpg",
                            GenreId = 6,
                            InstrumentTypeId = 1,
                            Name = "Los Monsters",
                            Price = 20m,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 17,
                            ArtistId = 1,
                            Description = "INSTRUMENT | Finish: Natural - Siam Oak drum shell met natuurlijke bekleding - Top: Ø 4.5' - ongeveer 28 cm hoog - Mini Comfort Curve II Rims",
                            Foto = "instrumentPerc1.jpg",
                            GenreId = 1,
                            InstrumentTypeId = 2,
                            Name = "LPM198 Mini afstelbare conga",
                            Price = 60m,
                            ProductTypeId = 2
                        },
                        new
                        {
                            Id = 18,
                            ArtistId = 1,
                            Description = "INSTRUMENT | Eenvoudig houten percussieinstrument. - Wordt geleverd in paren.",
                            Foto = "instrumentPerc2.jpg",
                            GenreId = 1,
                            InstrumentTypeId = 2,
                            Name = "Grote houten Maracas",
                            Price = 20m,
                            ProductTypeId = 2
                        },
                        new
                        {
                            Id = 19,
                            ArtistId = 1,
                            Description = "INSTRUMENT |",
                            Foto = "instrumentString1.jpg",
                            GenreId = 1,
                            InstrumentTypeId = 3,
                            Name = "Vera Cruz Harp",
                            Price = 50m,
                            ProductTypeId = 2
                        },
                        new
                        {
                            Id = 20,
                            ArtistId = 1,
                            Description = "INSTRUMENT | RoseWood houten rug, glossy finish, handgemaakt",
                            Foto = "instrumentString2.jpg",
                            GenreId = 1,
                            InstrumentTypeId = 3,
                            Name = "Baja Sexto",
                            Price = 470m,
                            ProductTypeId = 2
                        },
                        new
                        {
                            Id = 21,
                            ArtistId = 1,
                            Description = "INSTRUMENT | Handgemaakt, vervaardigd uit bamboe Hand crafted, precisie afstemming,",
                            Foto = "instrumentWind1.jpg",
                            GenreId = 1,
                            InstrumentTypeId = 4,
                            Name = "Gewa Pan Pipe",
                            Price = 20m,
                            ProductTypeId = 2
                        },
                        new
                        {
                            Id = 22,
                            ArtistId = 1,
                            Description = "INSTRUMENT | Handgemaakt, vervaardigd uit zacht hout",
                            Foto = "instrumentWind2.jpg",
                            GenreId = 1,
                            InstrumentTypeId = 4,
                            Name = "Quena pamfluit",
                            Price = 45m,
                            ProductTypeId = 2
                        },
                        new
                        {
                            Id = 23,
                            ArtistId = 2,
                            Description = "PARTITUUR | Shakira bladmuziek - Nummer: Whenever, Wherever",
                            Foto = "scoreSha1.png",
                            GenreId = 2,
                            InstrumentTypeId = 1,
                            Name = "Whenever, wherever",
                            Price = 9.99m,
                            ProductTypeId = 3
                        },
                        new
                        {
                            Id = 24,
                            ArtistId = 2,
                            Description = "PARTITUUR | Shakira bladmuziek - Nummer: Hips don't Lie",
                            Foto = "scoreSha2.png",
                            GenreId = 2,
                            InstrumentTypeId = 1,
                            Name = "Hips don't Lie",
                            Price = 9.99m,
                            ProductTypeId = 3
                        },
                        new
                        {
                            Id = 25,
                            ArtistId = 3,
                            Description = "PARTITUUR | Juanes bladmuziek - Nummer: La Camisa Negra",
                            Foto = "scoreJua1.png",
                            GenreId = 2,
                            InstrumentTypeId = 1,
                            Name = "La Camisa Negra",
                            Price = 9.99m,
                            ProductTypeId = 3
                        },
                        new
                        {
                            Id = 26,
                            ArtistId = 3,
                            Description = "PARTITUUR | Juanes bladmuziek - Song: Juntos",
                            Foto = "scoreJua2.png",
                            GenreId = 2,
                            InstrumentTypeId = 1,
                            Name = "Juntos",
                            Price = 9.99m,
                            ProductTypeId = 3
                        },
                        new
                        {
                            Id = 27,
                            ArtistId = 4,
                            Description = "PARTITUUR | Marc Anthony sheet music - Song: Vivir mi Vida",
                            Foto = "scoreMar1.png",
                            GenreId = 3,
                            InstrumentTypeId = 1,
                            Name = "Vivir mi Vida",
                            Price = 9.99m,
                            ProductTypeId = 3
                        },
                        new
                        {
                            Id = 28,
                            ArtistId = 4,
                            Description = "Marc Anthony sheet music - Song: Te Conozco Bien",
                            Foto = "scoreMar2.png",
                            GenreId = 3,
                            InstrumentTypeId = 1,
                            Name = "Te Conozco Bien",
                            Price = 9.99m,
                            ProductTypeId = 3
                        },
                        new
                        {
                            Id = 29,
                            ArtistId = 5,
                            Description = "Grupo Niche sheet music - Song: Tapanco El Hueco",
                            Foto = "scoreGru1.png",
                            GenreId = 3,
                            InstrumentTypeId = 1,
                            Name = "Tapanco El Hueco",
                            Price = 9.99m,
                            ProductTypeId = 3
                        },
                        new
                        {
                            Id = 30,
                            ArtistId = 5,
                            Description = "Grupo Niche - Song: El Amor Vendra",
                            Foto = "scoreGru2.png",
                            GenreId = 3,
                            InstrumentTypeId = 1,
                            Name = "El Amor Vendra",
                            Price = 9.99m,
                            ProductTypeId = 3
                        },
                        new
                        {
                            Id = 31,
                            ArtistId = 6,
                            Description = "Maluma sheet music - Song: Felices los 4",
                            Foto = "scoreMal1.png",
                            GenreId = 4,
                            InstrumentTypeId = 1,
                            Name = "Felices Los 4",
                            Price = 9.99m,
                            ProductTypeId = 3
                        },
                        new
                        {
                            Id = 32,
                            ArtistId = 6,
                            Description = "Maluma sheet music - Song: Corazòn",
                            Foto = "scoreMal2.png",
                            GenreId = 4,
                            InstrumentTypeId = 1,
                            Name = "Corazòn",
                            Price = 9.99m,
                            ProductTypeId = 3
                        },
                        new
                        {
                            Id = 33,
                            ArtistId = 7,
                            Description = "Chino y Nacho sheet music - Song: Andas en mi Cabeza",
                            Foto = "scoreChi1.png",
                            GenreId = 4,
                            InstrumentTypeId = 1,
                            Name = "Andas en mi Cabeza",
                            Price = 9.99m,
                            ProductTypeId = 3
                        },
                        new
                        {
                            Id = 34,
                            ArtistId = 7,
                            Description = "Chino y Nacho sheet music - Song: Mi Niña Bonita",
                            Foto = "scoreChi2.png",
                            GenreId = 4,
                            InstrumentTypeId = 1,
                            Name = "Mi Niña Bonita",
                            Price = 9.99m,
                            ProductTypeId = 3
                        },
                        new
                        {
                            Id = 35,
                            ArtistId = 8,
                            Description = "Carlos Vives - Song: Déjame Entrar",
                            Foto = "scoreCar1.png",
                            GenreId = 5,
                            InstrumentTypeId = 1,
                            Name = "Déjame Entrar",
                            Price = 9.99m,
                            ProductTypeId = 3
                        },
                        new
                        {
                            Id = 36,
                            ArtistId = 8,
                            Description = "Carlos Vives sheet music - Song: Carito",
                            Foto = "scoreCar2.png",
                            GenreId = 5,
                            InstrumentTypeId = 1,
                            Name = "Carito",
                            Price = 9.99m,
                            ProductTypeId = 3
                        },
                        new
                        {
                            Id = 37,
                            ArtistId = 9,
                            Description = "Elvis Crespo sheet music - Song: Suavemente",
                            Foto = "scoreElv1.png",
                            GenreId = 6,
                            InstrumentTypeId = 1,
                            Name = "Suavemente",
                            Price = 9.99m,
                            ProductTypeId = 3
                        },
                        new
                        {
                            Id = 38,
                            ArtistId = 9,
                            Description = "Elvis Crespo sheet music - Song: Pintame",
                            Foto = "scoreElv2.png",
                            GenreId = 6,
                            InstrumentTypeId = 1,
                            Name = "Pintame",
                            Price = 9.99m,
                            ProductTypeId = 3
                        });
                });

            modelBuilder.Entity("Maracas.Lib.Models.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cd"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Instrument"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Score"
                        });
                });

            modelBuilder.Entity("Maracas.Lib.Models.Artist", b =>
                {
                    b.HasOne("Maracas.Lib.Models.Genre", "Genre")
                        .WithMany("Artists")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Maracas.Lib.Models.Order", b =>
                {
                    b.HasOne("Maracas.Lib.Models.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Maracas.Lib.Models.OrderDetails", b =>
                {
                    b.HasOne("Maracas.Lib.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Maracas.Lib.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Maracas.Lib.Models.Product", b =>
                {
                    b.HasOne("Maracas.Lib.Models.Artist", "Artist")
                        .WithMany("Products")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Maracas.Lib.Models.Genre", "Genre")
                        .WithMany("Products")
                        .HasForeignKey("GenreId");

                    b.HasOne("Maracas.Lib.Models.InstrumentType", "InstrumentType")
                        .WithMany("Products")
                        .HasForeignKey("InstrumentTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Maracas.Lib.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
