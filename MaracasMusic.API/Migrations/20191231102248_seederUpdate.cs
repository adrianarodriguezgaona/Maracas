using Microsoft.EntityFrameworkCore.Migrations;

namespace MaracasMusic.API.Migrations
{
    public partial class seederUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Engels|maart 2014 -- Shakira");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Engels|mei 2017 -- Shakira");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|september 2004 -- Juanes");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|mei 2002 -- Juanes");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|juli 2013 -- Marc Anthony");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|juli 2006 |Verzamelalbum -- Marc Anthony");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|juni 1994  |Verzamelalbum -- Grupo Niche");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|november 2015 -- Grupo Niche ");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|mei 2019 -- Maluma");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|mei 2018 -- Maluma");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|October 2011 -- Chino y Nacho");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|June 23, 2015 -- Chino y Nacho");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|Nov 10, 2017 -- Carlos Vives");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|May 13, 2014 -- Carlos Vives");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|april 1998 -- Elvis Crespo");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|mei 2012 -- Elvis Crespo");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Name" },
                values: new object[] { "INSTRUMENT | Finish: Natural - Siam Oak drum shell met natuurlijke bekleding - Top: Ø 4.5' - ongeveer 28 cm hoog - Mini Comfort Curve II Rims", "LPM198 Mini afstelbare conga" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Name" },
                values: new object[] { "INSTRUMENT | Eenvoudig houten percussieinstrument. - Wordt geleverd in paren.", "Grote houten Maracas" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "Description",
                value: "INSTRUMENT |");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "INSTRUMENT | RoseWood houten rug, glossy finish, handgemaakt");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Foto" },
                values: new object[] { "INSTRUMENT | Handgemaakt, vervaardigd uit bamboe Hand crafted, precisie afstemming,", "instrumentWind1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Foto", "Name" },
                values: new object[] { "INSTRUMENT | Handgemaakt, vervaardigd uit zacht hout", "instrumentWind2.jpg", "Quena pamfluit" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Foto" },
                values: new object[] { "PARTITUUR | Shakira bladmuziek - Nummer: Whenever, Wherever", "scoreSha1.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Foto" },
                values: new object[] { "PARTITUUR | Shakira bladmuziek - Nummer: Hips don't Lie", "scoreSha2.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Foto" },
                values: new object[] { "PARTITUUR | Juanes bladmuziek - Nummer: La Camisa Negra", "scoreJua1.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "Foto" },
                values: new object[] { "PARTITUUR | Juanes bladmuziek - Song: Juntos", "scoreJua2.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "Foto" },
                values: new object[] { "PARTITUUR | Marc Anthony sheet music - Song: Vivir mi Vida", "scoreMar1.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "Foto",
                value: "scoreMar2.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "Foto",
                value: "scoreGru1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "Foto",
                value: "scoreGru2.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "Foto",
                value: "scoreMal1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "Foto",
                value: "scoreMal2.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "Foto",
                value: "scoreChi1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "Foto",
                value: "scoreChi2.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "Foto",
                value: "scoreCar1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "Foto",
                value: "scoreCar2.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "Foto",
                value: "scoreElv1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "Foto",
                value: "scoreElv2.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Engels|maart 2014");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Engels|mei 2017");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|september 2004");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|mei 2002");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|juli 2013");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|juli 2006 |Verzamelalbum");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|juni 1994  |Verzamelalbum");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|november 2015 ");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|mei 2019 ");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|mei 2018 ");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|October 2011");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|June 23, 2015");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|Nov 10, 2017");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|May 13, 2014");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|april 1998");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "CD (ALBUM) |1 disk |Spaans|mei 2012");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Finish: Natural - Siam Oak drum shell with natural head - Head: Ø 4.5' - Approx. 28 cm high - Mini Comfort Curve II Rims", "LPM198 Mini Tuneable Conga" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Simple wooden percussion instrument, deliverd in pairs", "Large Wooden Maracas" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "RoseWood back, glossy finish, hand crafted");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Foto" },
                values: new object[] { "Hand crafted, made of Bamboo, pure tuning", "instrumentWind1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Foto", "Name" },
                values: new object[] { "Hand crafted, made of plum wood", "instrumentWind2", "Quena Flute" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Foto" },
                values: new object[] { "Shakira sheet music - Song: Whenever, Wherever", "scoreSha1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Foto" },
                values: new object[] { "Shakira sheet music - Song: Hips don't Lie", "scoreSha2.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Foto" },
                values: new object[] { "Juanes sheet music - Song: La Camisa Negra", "scoreJua1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "Foto" },
                values: new object[] { "Juanes sheet music - Song: Juntos", "scoreJua2.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "Foto" },
                values: new object[] { "Marc Anthony sheet music - Song: Vivir mi Vida", "scoreMar1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "Foto",
                value: "scoreMar2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "Foto",
                value: "scoreGru1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "Foto",
                value: "scoreGru2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "Foto",
                value: "scoreMal1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "Foto",
                value: "scoreMal2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "Foto",
                value: "scoreChi1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "Foto",
                value: "scoreChi2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "Foto",
                value: "scoreCar1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "Foto",
                value: "scoreCar2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "Foto",
                value: "scoreElv1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "Foto",
                value: "scoreElv2.jpg");
        }
    }
}
