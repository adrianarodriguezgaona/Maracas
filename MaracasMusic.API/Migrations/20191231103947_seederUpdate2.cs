using Microsoft.EntityFrameworkCore.Migrations;

namespace MaracasMusic.API.Migrations
{
    public partial class seederUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "Description",
                value: "PARTITUUR | Juanes bladmuziek - Nummer: Juntos");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "Description",
                value: "PARTITUUR | Marc Anthony sheet music - Nummer: Vivir mi Vida");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "Description",
                value: "Marc Anthony bladmuziek - Nummer: Te Conozco Bien");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "Description",
                value: "Grupo Niche bladmuziek - Nummer: Tapanco El Hueco");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "Description",
                value: "Grupo Niche - Nummer: El Amor Vendra");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "Description",
                value: "Maluma bladmuziek - Nummer: Felices los 4");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "Description",
                value: "Maluma bladmuziek - Nummer: Corazòn");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "Description",
                value: "Chino y Nacho bladmuziek - Nummer: Andas en mi Cabeza");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "Description",
                value: "Chino y Nacho bladmuziek - Nummer: Mi Niña Bonita");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "Description",
                value: "Carlos Vives - Nummer: Déjame Entrar");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "Description",
                value: "Carlos Vives bladmuziek - Nummer: Carito");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "Description",
                value: "Elvis Crespo bladmuziek - Nummer: Suavemente");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "Description",
                value: "Elvis Crespo bladmuziek - Nummer: Pintame");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "Description",
                value: "PARTITUUR | Juanes bladmuziek - Song: Juntos");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "Description",
                value: "PARTITUUR | Marc Anthony sheet music - Song: Vivir mi Vida");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "Description",
                value: "Marc Anthony sheet music - Song: Te Conozco Bien");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "Description",
                value: "Grupo Niche sheet music - Song: Tapanco El Hueco");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "Description",
                value: "Grupo Niche - Song: El Amor Vendra");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "Description",
                value: "Maluma sheet music - Song: Felices los 4");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "Description",
                value: "Maluma sheet music - Song: Corazòn");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "Description",
                value: "Chino y Nacho sheet music - Song: Andas en mi Cabeza");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "Description",
                value: "Chino y Nacho sheet music - Song: Mi Niña Bonita");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "Description",
                value: "Carlos Vives - Song: Déjame Entrar");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "Description",
                value: "Carlos Vives sheet music - Song: Carito");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "Description",
                value: "Elvis Crespo sheet music - Song: Suavemente");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "Description",
                value: "Elvis Crespo sheet music - Song: Pintame");
        }
    }
}
