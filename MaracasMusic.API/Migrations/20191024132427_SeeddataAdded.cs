using Microsoft.EntityFrameworkCore.Migrations;

namespace MaracasMusic.API.Migrations
{
    public partial class SeeddataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cds_ProductTypes_ProductTypeId",
                table: "Cds");

            migrationBuilder.DropForeignKey(
                name: "FK_Instruments_InstrumentTypes_InstrumentTypeId",
                table: "Instruments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instruments_ProductTypes_ProductTypeId",
                table: "Instruments");

            migrationBuilder.DropForeignKey(
                name: "FK_Scores_Artists_ArtistId",
                table: "Scores");

            migrationBuilder.DropForeignKey(
                name: "FK_Scores_Genre_GenreId",
                table: "Scores");

            migrationBuilder.DropForeignKey(
                name: "FK_Scores_ProductTypes_ProductTypeId",
                table: "Scores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Scores",
                table: "Scores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTypes",
                table: "ProductTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InstrumentTypes",
                table: "InstrumentTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instruments",
                table: "Instruments");

            migrationBuilder.RenameTable(
                name: "Scores",
                newName: "Score");

            migrationBuilder.RenameTable(
                name: "ProductTypes",
                newName: "ProductType");

            migrationBuilder.RenameTable(
                name: "InstrumentTypes",
                newName: "InstrumentType");

            migrationBuilder.RenameTable(
                name: "Instruments",
                newName: "Instrument");

            migrationBuilder.RenameIndex(
                name: "IX_Scores_ProductTypeId",
                table: "Score",
                newName: "IX_Score_ProductTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Scores_GenreId",
                table: "Score",
                newName: "IX_Score_GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_Scores_ArtistId",
                table: "Score",
                newName: "IX_Score_ArtistId");

            migrationBuilder.RenameIndex(
                name: "IX_Instruments_ProductTypeId",
                table: "Instrument",
                newName: "IX_Instrument_ProductTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Instruments_InstrumentTypeId",
                table: "Instrument",
                newName: "IX_Instrument_InstrumentTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Score",
                table: "Score",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductType",
                table: "ProductType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstrumentType",
                table: "InstrumentType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instrument",
                table: "Instrument",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Genre",
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
                table: "InstrumentType",
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
                    { 4L, "CD (ALBUM) |1 disk |Spaans|mei 2002", "CdJuanes1", 0L, 9m, 1L },
                    { 5L, "CD (ALBUM) |1 disk |Spaans|juli 2013", "CdMarcA1", 0L, 11m, 1L },
                    { 2L, "CD (ALBUM) |1 disk |Engels|mei 2017", "CdShakira2", 0L, 10m, 1L },
                    { 7L, "CD (ALBUM) |1 disk |Spaans|juni 1994  |Verzamelalbum", "CdGrupoN1", 0L, 15m, 1L },
                    { 8L, "CD (ALBUM) |1 disk |Spaans|november 2015 ", "CdGrupoN2", 0L, 20m, 1L },
                    { 9L, "CD (ALBUM) |1 disk |Spaans|mei 2019 ", "CdMaluma1", 0L, 22m, 1L },
                    { 10L, "CD (ALBUM) |1 disk |Spaans|mei 2018 ", "CdMaluma2", 0L, 22m, 1L },
                    { 11L, "CD (ALBUM) |1 disk |Spaans|October 2011", "CdChino1", 0L, 20m, 1L },
                    { 12L, "CD (ALBUM) |1 disk |Spaans|June 23, 2015", "CdChino2", 0L, 18m, 1L },
                    { 13L, "CD (ALBUM) |1 disk |Spaans|Nov 10, 2017", "CdVives1", 0L, 18m, 1L },
                    { 14L, "CD (ALBUM) |1 disk |Spaans|May 13, 2014", "CdVives2", 0L, 18m, 1L },
                    { 15L, "CD (ALBUM) |1 disk |Spaans|april 1998", "CdElvisC1", 0L, 18m, 1L },
                    { 16L, "CD (ALBUM) |1 disk |Spaans|mei 2012", "CdElvisC2", 0L, 20m, 1L },
                    { 1L, "CD (ALBUM) |1 disk |Engels|maart 2014", "CdShakira1", 0L, 11m, 1L },
                    { 3L, "CD (ALBUM) |1 disk |Spaans|september 2004", "CdJuanes1", 0L, 11m, 1L },
                    { 6L, "CD (ALBUM) |1 disk |Spaans|juli 2006 |Verzamelalbum", "CdMarcA2", 0L, 11m, 1L }
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
                table: "Instrument",
                columns: new[] { "Id", "InstrumentTypeId", "Name", "ProductId", "ProductTypeId" },
                values: new object[,]
                {
                    { 1L, 1L, "LPM198 Mini Tuneable Conga", 17L, 2L },
                    { 2L, 1L, "Large Wooden Maracas", 18L, 2L },
                    { 3L, 2L, "Vera Cruz Harp", 19L, 2L },
                    { 4L, 2L, "Baja Sexto", 20L, 2L },
                    { 5L, 3L, "Gewa Pan Pipe", 21L, 2L },
                    { 6L, 4L, "Quena Flute", 22L, 2L }
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
                table: "Score",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Cds_ProductType_ProductTypeId",
                table: "Cds",
                column: "ProductTypeId",
                principalTable: "ProductType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instrument_InstrumentType_InstrumentTypeId",
                table: "Instrument",
                column: "InstrumentTypeId",
                principalTable: "InstrumentType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instrument_ProductType_ProductTypeId",
                table: "Instrument",
                column: "ProductTypeId",
                principalTable: "ProductType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Score_Artists_ArtistId",
                table: "Score",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Score_Genre_GenreId",
                table: "Score",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Score_ProductType_ProductTypeId",
                table: "Score",
                column: "ProductTypeId",
                principalTable: "ProductType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cds_ProductType_ProductTypeId",
                table: "Cds");

            migrationBuilder.DropForeignKey(
                name: "FK_Instrument_InstrumentType_InstrumentTypeId",
                table: "Instrument");

            migrationBuilder.DropForeignKey(
                name: "FK_Instrument_ProductType_ProductTypeId",
                table: "Instrument");

            migrationBuilder.DropForeignKey(
                name: "FK_Score_Artists_ArtistId",
                table: "Score");

            migrationBuilder.DropForeignKey(
                name: "FK_Score_Genre_GenreId",
                table: "Score");

            migrationBuilder.DropForeignKey(
                name: "FK_Score_ProductType_ProductTypeId",
                table: "Score");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Score",
                table: "Score");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductType",
                table: "ProductType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InstrumentType",
                table: "InstrumentType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instrument",
                table: "Instrument");

            migrationBuilder.DeleteData(
                table: "Cds",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Cds",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Cds",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Cds",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Cds",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Cds",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Cds",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Cds",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Cds",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Cds",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Cds",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Cds",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Cds",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Cds",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Cds",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Cds",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Instrument",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Instrument",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Instrument",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Instrument",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Instrument",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Instrument",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Score",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Score",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Score",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Score",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Score",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Score",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Score",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Score",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Score",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Score",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Score",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Score",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Score",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Score",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Score",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Score",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "InstrumentType",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "InstrumentType",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "InstrumentType",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.RenameTable(
                name: "Score",
                newName: "Scores");

            migrationBuilder.RenameTable(
                name: "ProductType",
                newName: "ProductTypes");

            migrationBuilder.RenameTable(
                name: "InstrumentType",
                newName: "InstrumentTypes");

            migrationBuilder.RenameTable(
                name: "Instrument",
                newName: "Instruments");

            migrationBuilder.RenameIndex(
                name: "IX_Score_ProductTypeId",
                table: "Scores",
                newName: "IX_Scores_ProductTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Score_GenreId",
                table: "Scores",
                newName: "IX_Scores_GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_Score_ArtistId",
                table: "Scores",
                newName: "IX_Scores_ArtistId");

            migrationBuilder.RenameIndex(
                name: "IX_Instrument_ProductTypeId",
                table: "Instruments",
                newName: "IX_Instruments_ProductTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Instrument_InstrumentTypeId",
                table: "Instruments",
                newName: "IX_Instruments_InstrumentTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Scores",
                table: "Scores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTypes",
                table: "ProductTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstrumentTypes",
                table: "InstrumentTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instruments",
                table: "Instruments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cds_ProductTypes_ProductTypeId",
                table: "Cds",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instruments_InstrumentTypes_InstrumentTypeId",
                table: "Instruments",
                column: "InstrumentTypeId",
                principalTable: "InstrumentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instruments_ProductTypes_ProductTypeId",
                table: "Instruments",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Scores_Artists_ArtistId",
                table: "Scores",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Scores_Genre_GenreId",
                table: "Scores",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Scores_ProductTypes_ProductTypeId",
                table: "Scores",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
