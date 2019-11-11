using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MaracasMusic.API.Migrations
{
    public partial class fix1 : Migration
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
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
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
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
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
                    GenreId = table.Column<long>(nullable: true),
                    GenreId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Artists_Genres_GenreId1",
                        column: x => x.GenreId1,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: true),
                    ArtistId = table.Column<int>(nullable: true),
                    GenreId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cds_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cds_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cds_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Instruments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: true),
                    InstrumentTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instruments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instruments_InstrumentTypes_InstrumentTypeId",
                        column: x => x.InstrumentTypeId,
                        principalTable: "InstrumentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Instruments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: true),
                    ArtistId = table.Column<int>(nullable: true),
                    GenreId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Scores_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Scores_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Scores_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "GenreId", "GenreId1", "Name" },
                values: new object[,]
                {
                    { 1, 1L, null, "Shakira" },
                    { 2, 1L, null, "Juanes" },
                    { 3, 2L, null, "Marc Anthony" },
                    { 4, 2L, null, "Grupo Niche" },
                    { 5, 3L, null, "Maluma" },
                    { 6, 3L, null, "Chino y Nacho" },
                    { 7, 4L, null, "Carlos Vives" },
                    { 8, 5L, null, "Elvis Crespo" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Cumbia" },
                    { 4, "Cumbia" },
                    { 2, "Salsa" },
                    { 1, "Pop Muziek" },
                    { 3, "Regueton" }
                });

            migrationBuilder.InsertData(
                table: "InstrumentTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Percussion" },
                    { 2, "Strings" },
                    { 3, "Winds" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[,]
                {
                    { 2, null, "Instrument" },
                    { 1, null, "Cd" },
                    { 3, null, "Score" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Foto", "Name", "OrderId", "Price", "ProductTypeId" },
                values: new object[,]
                {
                    { 1, "CD (ALBUM) |1 disk |Engels|maart 2014", "CdShakira1.jpg", null, null, 11m, 1 },
                    { 22, "Hand crafted, made of plum wood", "instrumentWind2", null, null, 45m, 2 },
                    { 23, "Shakira sheet music - Song: Whenever, Wherever", "scoreSha1.jpg", null, null, 9.99m, 3 },
                    { 24, "Shakira sheet music - Song: Hips don't Lie", "scoreSha2.jpg", null, null, 9.99m, 3 },
                    { 25, "Juanes sheet music - Song: La Camisa Negra", "scoreJua1.jpg", null, null, 9.99m, 3 },
                    { 26, "Juanes sheet music - Song: Juentos", "scoreJua2.jpg", null, null, 9.99m, 3 },
                    { 27, "Marc Anthony sheet music - Song: Vivir mi Vida", "scoreMar1.jpg", null, null, 9.99m, 3 },
                    { 28, "Marc Anthony sheet music - Song: Te Conozco Bien", "scoreMar2.jpg", null, null, 9.99m, 3 },
                    { 29, "Grupo Niche sheet music - Song: Tapanco El Hueco", "scoreGru1.jpg", null, null, 9.99m, 3 },
                    { 30, "Grupo Niche - Song: El Amor Vendra", "scoreGru2.jpg", null, null, 9.99m, 3 },
                    { 31, "Maluma sheet music - Song: Felices los 4", "scoreMal1.jpg", null, null, 9.99m, 3 },
                    { 32, "Maluma sheet music - Song: Corazòn", "scoreMal2.jpg", null, null, 9.99m, 3 },
                    { 33, "Chino y Nacho sheet music - Song: Andas en mi Cabeza", "scoreChi1.jpg", null, null, 9.99m, 3 },
                    { 34, "Chino y Nacho sheet music - Song: Mi Niña Bonita", "scoreChi2.jpg", null, null, 9.99m, 3 },
                    { 35, "Carlos Vives - Song: Déjame Entrar", "scoreCar1.jpg", null, null, 9.99m, 3 },
                    { 36, "Carlos Vives sheet music - Song: Carito", "scoreCar2.jpg", null, null, 9.99m, 3 },
                    { 21, "Hand crafted, made of Bamboo, pure tuning", "instrumentWind1", null, null, 20m, 2 },
                    { 20, "RoseWood back, glossy finish, hand crafted", "instrumentString2.jpg", null, null, 470m, 2 },
                    { 19, "", "instrumentString1.jpg", null, null, 50m, 2 },
                    { 18, "Simple wooden percussion instrument, deliverd in pairs", "instrumentPerc2.jpg", null, null, 20m, 2 },
                    { 2, "CD (ALBUM) |1 disk |Engels|mei 2017", "CdShakira2.jpg", null, null, 10m, 1 },
                    { 3, "CD (ALBUM) |1 disk |Spaans|september 2004", "CdJuanes1.jpg", null, null, 11m, 1 },
                    { 4, "CD (ALBUM) |1 disk |Spaans|mei 2002", "CdJuanes2.jpg", null, null, 9m, 1 },
                    { 5, "CD (ALBUM) |1 disk |Spaans|juli 2013", "CdMarcA1.jpg", null, null, 11m, 1 },
                    { 6, "CD (ALBUM) |1 disk |Spaans|juli 2006 |Verzamelalbum", "CdMarcA2.jpg", null, null, 11m, 1 },
                    { 7, "CD (ALBUM) |1 disk |Spaans|juni 1994  |Verzamelalbum", "CdGrupoN1.jpg", null, null, 15m, 1 },
                    { 8, "CD (ALBUM) |1 disk |Spaans|november 2015 ", "CdGrupoN2.jpg", null, null, 20m, 1 },
                    { 37, "Elvis Crespo sheet music - Song: Suavemente", "scoreElv1.jpg", null, null, 9.99m, 3 },
                    { 9, "CD (ALBUM) |1 disk |Spaans|mei 2019 ", "CdMaluma1.jpg", null, null, 22m, 1 },
                    { 11, "CD (ALBUM) |1 disk |Spaans|October 2011", "CdChino1.jpg", null, null, 20m, 1 },
                    { 12, "CD (ALBUM) |1 disk |Spaans|June 23, 2015", "CdChino2.jpg", null, null, 18m, 1 },
                    { 13, "CD (ALBUM) |1 disk |Spaans|Nov 10, 2017", "CdVives1.jpg", null, null, 18m, 1 },
                    { 14, "CD (ALBUM) |1 disk |Spaans|May 13, 2014", "CdVives2.jpg", null, null, 18m, 1 },
                    { 15, "CD (ALBUM) |1 disk |Spaans|april 1998", "CdElvisC1.jpg", null, null, 18m, 1 },
                    { 16, "CD (ALBUM) |1 disk |Spaans|mei 2012", "CdElvisC2.jpg", null, null, 20m, 1 },
                    { 17, "Finish: Natural - Siam Oak drum shell with natural head - Head: Ø 4.5' - Approx. 28 cm high - Mini Comfort Curve II Rims", "instrumentPerc1.jpg", null, null, 60m, 2 },
                    { 10, "CD (ALBUM) |1 disk |Spaans|mei 2018 ", "CdMaluma2.jpg", null, null, 22m, 1 },
                    { 38, "Elvis Crespo sheet music - Song: Pintame", "scoreElv2.jpg", null, null, 9.99m, 3 }
                });

            migrationBuilder.InsertData(
                table: "Cds",
                columns: new[] { "Id", "ArtistId", "GenreId", "Name", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, 1, "Shakira", 1 },
                    { 16, 8, 5, "Los Monsters", 16 },
                    { 15, 8, 5, "Suavemente", 15 },
                    { 14, 7, 4, "Más + Corazón Profundo", 14 },
                    { 13, 7, 4, "VIVES", 13 },
                    { 12, 6, 3, "Radio universo", 12 },
                    { 11, 6, 3, "Supremo", 11 },
                    { 9, 5, 3, "11:11", 9 },
                    { 10, 5, 3, "F.A.M.E", 10 },
                    { 7, 4, 2, "Brillantes", 7 },
                    { 6, 3, 2, "Sigo siendo yo", 6 },
                    { 5, 3, 2, "3.0", 5 },
                    { 4, 2, 1, "Un dia normal", 4 },
                    { 3, 2, 1, "Mi sangre", 3 },
                    { 2, 1, 1, "El Dorado", 2 },
                    { 8, 4, 2, "Bonitas y hermosas", 8 }
                });

            migrationBuilder.InsertData(
                table: "Instruments",
                columns: new[] { "Id", "InstrumentTypeId", "Name", "ProductId" },
                values: new object[,]
                {
                    { 5, 3, "Gewa Pan Pipe", 21 },
                    { 6, 3, "Quena Flute", 22 },
                    { 4, 2, "Baja Sexto", 20 },
                    { 3, 2, "Vera Cruz Harp", 19 },
                    { 2, 1, "Large Wooden Maracas", 18 },
                    { 1, 1, "LPM198 Mini Tuneable Conga", 17 }
                });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "ArtistId", "GenreId", "Name", "ProductId" },
                values: new object[,]
                {
                    { 14, 7, 4, "Carito", 36 },
                    { 13, 7, 4, "Déjame Entrar", 35 },
                    { 12, 6, 3, "Mi Niña Bonita", 34 },
                    { 11, 6, 3, "Andas en mi Cabeza", 33 },
                    { 10, 5, 3, "Corazòn", 32 },
                    { 9, 5, 3, "Felices Los 4", 31 },
                    { 8, 4, 2, "El Amor Vendra", 30 },
                    { 7, 4, 2, "Tapanco El Hueco", 29 },
                    { 6, 3, 2, "Te Conozco Bien", 28 },
                    { 5, 3, 2, "Vivir mi Vida", 27 },
                    { 4, 2, 1, "Juntos", 26 },
                    { 3, 2, 1, "La Camisa Negra", 25 },
                    { 2, 1, 1, "Hips don't Lie", 24 },
                    { 1, 1, 1, "Whenever, wherever", 23 },
                    { 15, 8, 5, "Suavemente", 37 },
                    { 16, 8, 5, "Pintame", 38 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artists_GenreId1",
                table: "Artists",
                column: "GenreId1");

            migrationBuilder.CreateIndex(
                name: "IX_Cds_ArtistId",
                table: "Cds",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Cds_GenreId",
                table: "Cds",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Cds_ProductId",
                table: "Cds",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Instruments_InstrumentTypeId",
                table: "Instruments",
                column: "InstrumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Instruments_ProductId",
                table: "Instruments",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientId",
                table: "Orders",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderId",
                table: "Products",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeId",
                table: "Products",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_ArtistId",
                table: "Scores",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_GenreId",
                table: "Scores",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_ProductId",
                table: "Scores",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cds");

            migrationBuilder.DropTable(
                name: "Instruments");

            migrationBuilder.DropTable(
                name: "Scores");

            migrationBuilder.DropTable(
                name: "InstrumentTypes");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
