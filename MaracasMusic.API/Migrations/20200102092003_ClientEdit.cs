using Microsoft.EntityFrameworkCore.Migrations;

namespace MaracasMusic.API.Migrations
{
    public partial class ClientEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Clients",
                newName: "Password");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Orders",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "Description",
                value: "Marc Anthony bladmuziek - Song: Te Conozco Bien");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "Description",
                value: "Grupo Niche bladmuziek - Song: Tapanco El Hueco");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "Description",
                value: "Maluma bladmuziek - Song: Felices los 4");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "Description",
                value: "Maluma bladmuziek - Song: Corazòn");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "Description",
                value: "Chino y Nacho bladmuziek - Song: Andas en mi Cabeza");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "Description",
                value: "Chino y Nacho bladmuziek - Song: Mi Niña Bonita");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "Description",
                value: "Carlos Vives bladmuziek - Song: Carito");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "Description",
                value: "Elvis Crespo bladmuziek - Song: Suavemente");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "Description",
                value: "Elvis Crespo bladmuziek - Song: Pintame");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Clients",
                newName: "City");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Clients",
                nullable: true);

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
