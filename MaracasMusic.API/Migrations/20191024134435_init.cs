using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MaracasMusic.API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
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
                    Id = table.Column<long>(nullable: false)
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
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstrumentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductType",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientId = table.Column<long>(nullable: false)
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
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    GenreId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Artists_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Instruments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ProductId = table.Column<long>(nullable: false),
                    ProductTypeId = table.Column<long>(nullable: false),
                    InstrumentTypeId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instruments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instruments_InstrumentTypes_InstrumentTypeId",
                        column: x => x.InstrumentTypeId,
                        principalTable: "InstrumentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Instruments_ProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductTypeId = table.Column<long>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Foto = table.Column<string>(nullable: true),
                    OrderId = table.Column<long>(nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "Cds",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ProductId = table.Column<long>(nullable: false),
                    ArtistId = table.Column<long>(nullable: false),
                    ProductTypeId = table.Column<long>(nullable: false),
                    GenreId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cds_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cds_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cds_ProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ProductTypeId = table.Column<long>(nullable: false),
                    ArtistId = table.Column<long>(nullable: false),
                    GenreId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Scores_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Scores_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Scores_ProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Pop Muziek" },
                    { 2L, "Salsa" },
                    { 3L, "Regueton" },
                    { 4L, "Cumbia" },
                    { 5L, "Cumbia" }
                });

            migrationBuilder.InsertData(
                table: "InstrumentTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Percussion" },
                    { 2L, "Strings" },
                    { 3L, "Winds" }
                });

            migrationBuilder.InsertData(
                table: "ProductType",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1L, "Cd" },
                    { 2L, "Instrument" },
                    { 3L, "Score" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Foto", "OrderId", "Price", "ProductTypeId" },
                values: new object[,]
                {
                    { 4L, "CD (ALBUM) |1 disk |Spaans|mei 2002", "CdJuanes1", null, 9m, 1L },
                    { 5L, "CD (ALBUM) |1 disk |Spaans|juli 2013", "CdMarcA1", null, 11m, 1L },
                    { 2L, "CD (ALBUM) |1 disk |Engels|mei 2017", "CdShakira2", null, 10m, 1L },
                    { 7L, "CD (ALBUM) |1 disk |Spaans|juni 1994  |Verzamelalbum", "CdGrupoN1", null, 15m, 1L },
                    { 8L, "CD (ALBUM) |1 disk |Spaans|november 2015 ", "CdGrupoN2", null, 20m, 1L },
                    { 9L, "CD (ALBUM) |1 disk |Spaans|mei 2019 ", "CdMaluma1", null, 22m, 1L },
                    { 10L, "CD (ALBUM) |1 disk |Spaans|mei 2018 ", "CdMaluma2", null, 22m, 1L },
                    { 11L, "CD (ALBUM) |1 disk |Spaans|October 2011", "CdChino1", null, 20m, 1L },
                    { 12L, "CD (ALBUM) |1 disk |Spaans|June 23, 2015", "CdChino2", null, 18m, 1L },
                    { 13L, "CD (ALBUM) |1 disk |Spaans|Nov 10, 2017", "CdVives1", null, 18m, 1L },
                    { 14L, "CD (ALBUM) |1 disk |Spaans|May 13, 2014", "CdVives2", null, 18m, 1L },
                    { 15L, "CD (ALBUM) |1 disk |Spaans|april 1998", "CdElvisC1", null, 18m, 1L },
                    { 16L, "CD (ALBUM) |1 disk |Spaans|mei 2012", "CdElvisC2", null, 20m, 1L },
                    { 1L, "CD (ALBUM) |1 disk |Engels|maart 2014", "CdShakira1", null, 11m, 1L },
                    { 3L, "CD (ALBUM) |1 disk |Spaans|september 2004", "CdJuanes1", null, 11m, 1L },
                    { 6L, "CD (ALBUM) |1 disk |Spaans|juli 2006 |Verzamelalbum", "CdMarcA2", null, 11m, 1L }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "GenreId", "Name" },
                values: new object[,]
                {
                    { 1L, 1L, "Shakira" },
                    { 2L, 1L, "Juanes" },
                    { 3L, 2L, "Marc Anthony" },
                    { 4L, 2L, "Grupo Niche" },
                    { 5L, 3L, "Maluma" },
                    { 6L, 3L, "Chino y Nacho" },
                    { 7L, 4L, "Carlos Vives" },
                    { 8L, 5L, "Elvis Crespo" }
                });

            migrationBuilder.InsertData(
                table: "Instruments",
                columns: new[] { "Id", "InstrumentTypeId", "Name", "ProductId", "ProductTypeId" },
                values: new object[,]
                {
                    { 1L, 1L, "LPM198 Mini Tuneable Conga", 17L, 2L },
                    { 2L, 1L, "Large Wooden Maracas", 18L, 2L },
                    { 3L, 2L, "Vera Cruz Harp", 19L, 2L },
                    { 4L, 2L, "Baja Sexto", 20L, 2L },
                    { 5L, 3L, "Gewa Pan Pipe", 21L, 2L },
                    { 6L, 3L, "Quena Flute", 22L, 2L }
                });

            migrationBuilder.InsertData(
                table: "Cds",
                columns: new[] { "Id", "ArtistId", "GenreId", "Name", "ProductId", "ProductTypeId" },
                values: new object[,]
                {
                    { 1L, 1L, 1L, "Shakira", 1L, 1L },
                    { 10L, 5L, 3L, "F.A.M.E", 10L, 1L },
                    { 9L, 5L, 3L, "11:11", 9L, 1L },
                    { 8L, 4L, 2L, "Bonitas y hermosas", 8L, 1L },
                    { 7L, 4L, 2L, "Brillantes", 7L, 1L },
                    { 13L, 7L, 4L, "VIVES", 13L, 1L },
                    { 14L, 7L, 4L, "Más + Corazón Profundo", 14L, 1L },
                    { 12L, 6L, 3L, "Radio universo", 12L, 1L },
                    { 6L, 3L, 2L, "Sigo siendo yo", 6L, 1L },
                    { 4L, 2L, 1L, "Un dia normal", 4L, 1L },
                    { 3L, 2L, 1L, "Mi sangre", 3L, 1L },
                    { 15L, 8L, 5L, "Suavemente", 15L, 1L },
                    { 16L, 8L, 5L, "Los Monsters", 16L, 1L },
                    { 2L, 1L, 1L, "El Dorado", 2L, 1L },
                    { 5L, 3L, 2L, "3.0", 5L, 1L },
                    { 11L, 6L, 3L, "Supremo", 11L, 1L }
                });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "ArtistId", "GenreId", "Name", "ProductId", "ProductTypeId" },
                values: new object[,]
                {
                    { 13L, 7L, 4L, "Déjame Entrar", 35L, 3L },
                    { 14L, 7L, 4L, "Carito", 36L, 3L },
                    { 12L, 6L, 3L, "Mi Niña Bonita", 34L, 3L },
                    { 11L, 6L, 3L, "Andas en mi Cabeza", 33L, 3L },
                    { 8L, 4L, 2L, "El Amor Vendra", 30L, 3L },
                    { 9L, 5L, 3L, "Felices Los 4", 31L, 3L },
                    { 15L, 8L, 5L, "Suavemente", 37L, 3L },
                    { 7L, 4L, 2L, "Tapanco El Hueco", 29L, 3L },
                    { 6L, 3L, 2L, "Te Conozco Bien", 28L, 3L },
                    { 5L, 3L, 2L, "Vivir mi Vida", 27L, 3L },
                    { 4L, 2L, 1L, "Juntos", 26L, 3L },
                    { 3L, 2L, 1L, "La Camisa Negra", 25L, 3L },
                    { 2L, 1L, 1L, "Hips don't Lie", 24L, 3L },
                    { 1L, 1L, 1L, "Whenever, wherever", 23L, 3L },
                    { 10L, 5L, 3L, "Corazòn", 32L, 3L },
                    { 16L, 8L, 5L, "Pintame", 38L, 3L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artists_GenreId",
                table: "Artists",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Cds_ArtistId",
                table: "Cds",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Cds_GenreId",
                table: "Cds",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Cds_ProductTypeId",
                table: "Cds",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Instruments_InstrumentTypeId",
                table: "Instruments",
                column: "InstrumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Instruments_ProductTypeId",
                table: "Instruments",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientId",
                table: "Orders",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderId",
                table: "Products",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_ArtistId",
                table: "Scores",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_GenreId",
                table: "Scores",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_ProductTypeId",
                table: "Scores",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cds");

            migrationBuilder.DropTable(
                name: "Instruments");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Scores");

            migrationBuilder.DropTable(
                name: "InstrumentTypes");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "ProductType");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
