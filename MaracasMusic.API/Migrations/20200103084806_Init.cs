using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MaracasMusic.API.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstrumentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstrumentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ClientId = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    DateOrder = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Artists_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Foto = table.Column<string>(nullable: true),
                    ProductTypeId = table.Column<int>(nullable: false),
                    ArtistId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: true),
                    InstrumentTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_InstrumentTypes_InstrumentTypeId",
                        column: x => x.InstrumentTypeId,
                        principalTable: "InstrumentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Aantal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Geen genre" },
                    { 2, "Pop Muziek" },
                    { 3, "Salsa" },
                    { 4, "Regueton" },
                    { 5, "Cumbia" },
                    { 6, "Merengue" }
                });

            migrationBuilder.InsertData(
                table: "InstrumentTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Geen instrumentType" },
                    { 2, "Percussion" },
                    { 3, "Strings" },
                    { 4, "Winds" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Cd" },
                    { 2, "Instrument" },
                    { 3, "Score" }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "GenreId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Geen artiest" },
                    { 2, 2, "Shakira" },
                    { 3, 2, "Juanes" },
                    { 4, 3, "Marc Anthony" },
                    { 5, 3, "Grupo Niche" },
                    { 6, 4, "Maluma" },
                    { 7, 4, "Chino y Nacho" },
                    { 8, 5, "Carlos Vives" },
                    { 9, 6, "Elvis Crespo" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtistId", "Description", "Foto", "GenreId", "InstrumentTypeId", "Name", "Price", "ProductTypeId" },
                values: new object[,]
                {
                    { 17, 1, "INSTRUMENT | Finish: Natural - Siam Oak drum shell met natuurlijke bekleding - Top: Ø 4.5' - ongeveer 28 cm hoog - Mini Comfort Curve II Rims", "instrumentPerc1.jpg", 1, 2, "LPM198 Mini afstelbare conga", 60m, 2 },
                    { 30, 5, "Grupo Niche - Nummer: El Amor Vendra", "scoreGru2.png", 3, 1, "El Amor Vendra", 9.99m, 3 },
                    { 9, 6, "CD (ALBUM) |1 disk |Spaans|mei 2019 -- Maluma", "CdMaluma1.jpg", 4, 1, "11:11", 22m, 1 },
                    { 10, 6, "CD (ALBUM) |1 disk |Spaans|mei 2018 -- Maluma", "CdMaluma2.jpg", 4, 1, "F.A.M.E", 22m, 1 },
                    { 31, 6, "Maluma bladmuziek - Nummer: Felices los 4", "scoreMal1.png", 4, 1, "Felices Los 4", 9.99m, 3 },
                    { 32, 6, "Maluma bladmuziek - Nummer: Corazòn", "scoreMal2.png", 4, 1, "Corazòn", 9.99m, 3 },
                    { 11, 7, "CD (ALBUM) |1 disk |Spaans|October 2011 -- Chino y Nacho", "CdChino1.jpg", 4, 1, "Supremo", 20m, 1 },
                    { 12, 7, "CD (ALBUM) |1 disk |Spaans|June 23, 2015 -- Chino y Nacho", "CdChino2.jpg", 4, 1, "Radio universo", 18m, 1 },
                    { 33, 7, "Chino y Nacho bladmuziek - Nummer: Andas en mi Cabeza", "scoreChi1.png", 4, 1, "Andas en mi Cabeza", 9.99m, 3 },
                    { 34, 7, "Chino y Nacho bladmuziek - Nummer: Mi Niña Bonita", "scoreChi2.png", 4, 1, "Mi Niña Bonita", 9.99m, 3 },
                    { 13, 8, "CD (ALBUM) |1 disk |Spaans|Nov 10, 2017 -- Carlos Vives", "CdVives1.jpg", 5, 1, "VIVES", 18m, 1 },
                    { 14, 8, "CD (ALBUM) |1 disk |Spaans|May 13, 2014 -- Carlos Vives", "CdVives2.jpg", 5, 1, "Más + Corazón Profundo", 18m, 1 },
                    { 35, 8, "Carlos Vives - Nummer: Déjame Entrar", "scoreCar1.png", 5, 1, "Déjame Entrar", 9.99m, 3 },
                    { 36, 8, "Carlos Vives bladmuziek - Nummer: Carito", "scoreCar2.png", 5, 1, "Carito", 9.99m, 3 },
                    { 15, 9, "CD (ALBUM) |1 disk |Spaans|april 1998 -- Elvis Crespo", "CdElvis1.jpg", 6, 1, "Suavemente", 18m, 1 },
                    { 16, 9, "CD (ALBUM) |1 disk |Spaans|mei 2012 -- Elvis Crespo", "CdElvis2.jpg", 6, 1, "Los Monsters", 20m, 1 },
                    { 29, 5, "Grupo Niche bladmuziek - Nummer: Tapanco El Hueco", "scoreGru1.png", 3, 1, "Tapanco El Hueco", 9.99m, 3 },
                    { 8, 5, "CD (ALBUM) |1 disk |Spaans|november 2015 -- Grupo Niche ", "CdGrupoN2.jpg", 3, 1, "Bonitas y hermosas", 20m, 1 },
                    { 7, 5, "CD (ALBUM) |1 disk |Spaans|juni 1994  |Verzamelalbum -- Grupo Niche", "CdGrupoN1.jpg", 3, 1, "Brillantes", 15m, 1 },
                    { 28, 4, "Marc Anthony bladmuziek - Nummer: Te Conozco Bien", "scoreMar2.png", 3, 1, "Te Conozco Bien", 9.99m, 3 },
                    { 18, 1, "INSTRUMENT | Eenvoudig houten percussieinstrument. - Wordt geleverd in paren.", "instrumentPerc2.jpg", 1, 2, "Grote houten Maracas", 20m, 2 },
                    { 19, 1, "INSTRUMENT |", "instrumentString1.jpg", 1, 3, "Vera Cruz Harp", 50m, 2 },
                    { 20, 1, "INSTRUMENT | RoseWood houten rug, glossy finish, handgemaakt", "instrumentString2.jpg", 1, 3, "Baja Sexto", 470m, 2 },
                    { 21, 1, "INSTRUMENT | Handgemaakt, vervaardigd uit bamboe Hand crafted, precisie afstemming,", "instrumentWind1.jpg", 1, 4, "Gewa Pan Pipe", 20m, 2 },
                    { 22, 1, "INSTRUMENT | Handgemaakt, vervaardigd uit zacht hout", "instrumentWind2.jpg", 1, 4, "Quena pamfluit", 45m, 2 },
                    { 1, 2, "CD (ALBUM) |1 disk |Engels|maart 2014 -- Shakira", "CdShakira1.jpg", 2, 1, "El Dorado", 11m, 1 },
                    { 2, 2, "CD (ALBUM) |1 disk |Engels|mei 2017 -- Shakira", "CdShakira2.jpg", 2, 1, "Shakira", 10m, 1 },
                    { 37, 9, "Elvis Crespo bladmuziek - Nummer: Suavemente", "scoreElv1.png", 6, 1, "Suavemente", 9.99m, 3 },
                    { 23, 2, "PARTITUUR | Shakira bladmuziek - Nummer: Whenever, Wherever", "scoreSha1.png", 2, 1, "Whenever, wherever", 9.99m, 3 },
                    { 3, 3, "CD (ALBUM) |1 disk |Spaans|september 2004 -- Juanes", "CdJuanes1.jpg", 2, 1, "Mi sangre", 11m, 1 },
                    { 4, 3, "CD (ALBUM) |1 disk |Spaans|mei 2002 -- Juanes", "CdJuanes2.jpg", 2, 1, "Un dia normal", 9m, 1 },
                    { 25, 3, "PARTITUUR | Juanes bladmuziek - Nummer: La Camisa Negra", "scoreJua1.png", 2, 1, "La Camisa Negra", 9.99m, 3 },
                    { 26, 3, "PARTITUUR | Juanes bladmuziek - Nummer: Juntos", "scoreJua2.png", 2, 1, "Juntos", 9.99m, 3 },
                    { 5, 4, "CD (ALBUM) |1 disk |Spaans|juli 2013 -- Marc Anthony", "CdMarcA1.jpg", 3, 1, "3.0", 11m, 1 },
                    { 6, 4, "CD (ALBUM) |1 disk |Spaans|juli 2006 |Verzamelalbum -- Marc Anthony", "CdMarcA2.jpg", 3, 1, "Sigo siendo yo", 11m, 1 },
                    { 27, 4, "PARTITUUR | Marc Anthony sheet music - Nummer: Vivir mi Vida", "scoreMar1.png", 3, 1, "Vivir mi Vida", 9.99m, 3 },
                    { 24, 2, "PARTITUUR | Shakira bladmuziek - Nummer: Hips don't Lie", "scoreSha2.png", 2, 1, "Hips don't Lie", 9.99m, 3 },
                    { 38, 9, "Elvis Crespo bladmuziek - Nummer: Pintame", "scoreElv2.png", 6, 1, "Pintame", 9.99m, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artists_GenreId",
                table: "Artists",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientId",
                table: "Orders",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ArtistId",
                table: "Products",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_GenreId",
                table: "Products",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_InstrumentTypeId",
                table: "Products",
                column: "InstrumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeId",
                table: "Products",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "InstrumentTypes");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
