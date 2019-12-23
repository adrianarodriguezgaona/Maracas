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
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
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
                    { 17, 1, "Finish: Natural - Siam Oak drum shell with natural head - Head: Ø 4.5' - Approx. 28 cm high - Mini Comfort Curve II Rims", "instrumentPerc1.jpg", 1, 2, null, 60m, 2 },
                    { 30, 5, "Grupo Niche - Song: El Amor Vendra", "scoreGru2.jpg", 3, 1, null, 9.99m, 3 },
                    { 9, 6, "CD (ALBUM) |1 disk |Spaans|mei 2019 ", "CdMaluma1.jpg", 4, 1, null, 22m, 1 },
                    { 10, 6, "CD (ALBUM) |1 disk |Spaans|mei 2018 ", "CdMaluma2.jpg", 4, 1, null, 22m, 1 },
                    { 31, 6, "Maluma sheet music - Song: Felices los 4", "scoreMal1.jpg", 4, 1, null, 9.99m, 3 },
                    { 32, 6, "Maluma sheet music - Song: Corazòn", "scoreMal2.jpg", 4, 1, null, 9.99m, 3 },
                    { 11, 7, "CD (ALBUM) |1 disk |Spaans|October 2011", "CdChino1.jpg", 4, 1, null, 20m, 1 },
                    { 12, 7, "CD (ALBUM) |1 disk |Spaans|June 23, 2015", "CdChino2.jpg", 4, 1, null, 18m, 1 },
                    { 33, 7, "Chino y Nacho sheet music - Song: Andas en mi Cabeza", "scoreChi1.jpg", 4, 1, null, 9.99m, 3 },
                    { 34, 7, "Chino y Nacho sheet music - Song: Mi Niña Bonita", "scoreChi2.jpg", 4, 1, null, 9.99m, 3 },
                    { 13, 8, "CD (ALBUM) |1 disk |Spaans|Nov 10, 2017", "CdVives1.jpg", 5, 1, null, 18m, 1 },
                    { 14, 8, "CD (ALBUM) |1 disk |Spaans|May 13, 2014", "CdVives2.jpg", 5, 1, null, 18m, 1 },
                    { 35, 8, "Carlos Vives - Song: Déjame Entrar", "scoreCar1.jpg", 5, 1, null, 9.99m, 3 },
                    { 36, 8, "Carlos Vives sheet music - Song: Carito", "scoreCar2.jpg", 5, 1, null, 9.99m, 3 },
                    { 15, 9, "CD (ALBUM) |1 disk |Spaans|april 1998", "CdElvisC1.jpg", 6, 1, null, 18m, 1 },
                    { 16, 9, "CD (ALBUM) |1 disk |Spaans|mei 2012", "CdElvisC2.jpg", 6, 1, null, 20m, 1 },
                    { 29, 5, "Grupo Niche sheet music - Song: Tapanco El Hueco", "scoreGru1.jpg", 3, 1, null, 9.99m, 3 },
                    { 8, 5, "CD (ALBUM) |1 disk |Spaans|november 2015 ", "CdGrupoN2.jpg", 3, 1, null, 20m, 1 },
                    { 7, 5, "CD (ALBUM) |1 disk |Spaans|juni 1994  |Verzamelalbum", "CdGrupoN1.jpg", 3, 1, null, 15m, 1 },
                    { 28, 4, "Marc Anthony sheet music - Song: Te Conozco Bien", "scoreMar2.jpg", 3, 1, null, 9.99m, 3 },
                    { 18, 1, "Simple wooden percussion instrument, deliverd in pairs", "instrumentPerc2.jpg", 1, 2, null, 20m, 2 },
                    { 19, 1, "", "instrumentString1.jpg", 1, 3, null, 50m, 2 },
                    { 20, 1, "RoseWood back, glossy finish, hand crafted", "instrumentString2.jpg", 1, 3, null, 470m, 2 },
                    { 21, 1, "Hand crafted, made of Bamboo, pure tuning", "instrumentWind1", 1, 4, null, 20m, 2 },
                    { 22, 1, "Hand crafted, made of plum wood", "instrumentWind2", 1, 4, null, 45m, 2 },
                    { 1, 2, "CD (ALBUM) |1 disk |Engels|maart 2014", "CdShakira1.jpg", 2, 1, null, 11m, 1 },
                    { 2, 2, "CD (ALBUM) |1 disk |Engels|mei 2017", "CdShakira2.jpg", 2, 1, null, 10m, 1 },
                    { 37, 9, "Elvis Crespo sheet music - Song: Suavemente", "scoreElv1.jpg", 6, 1, null, 9.99m, 3 },
                    { 23, 2, "Shakira sheet music - Song: Whenever, Wherever", "scoreSha1.jpg", 2, 1, null, 9.99m, 3 },
                    { 3, 3, "CD (ALBUM) |1 disk |Spaans|september 2004", "CdJuanes1.jpg", 2, 1, null, 11m, 1 },
                    { 4, 3, "CD (ALBUM) |1 disk |Spaans|mei 2002", "CdJuanes2.jpg", 2, 1, null, 9m, 1 },
                    { 25, 3, "Juanes sheet music - Song: La Camisa Negra", "scoreJua1.jpg", 2, 1, null, 9.99m, 3 },
                    { 26, 3, "Juanes sheet music - Song: Juentos", "scoreJua2.jpg", 2, 1, null, 9.99m, 3 },
                    { 5, 4, "CD (ALBUM) |1 disk |Spaans|juli 2013", "CdMarcA1.jpg", 3, 1, null, 11m, 1 },
                    { 6, 4, "CD (ALBUM) |1 disk |Spaans|juli 2006 |Verzamelalbum", "CdMarcA2.jpg", 3, 1, null, 11m, 1 },
                    { 27, 4, "Marc Anthony sheet music - Song: Vivir mi Vida", "scoreMar1.jpg", 3, 1, null, 9.99m, 3 },
                    { 24, 2, "Shakira sheet music - Song: Hips don't Lie", "scoreSha2.jpg", 2, 1, null, 9.99m, 3 },
                    { 38, 9, "Elvis Crespo sheet music - Song: Pintame", "scoreElv2.jpg", 6, 1, null, 9.99m, 3 }
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
