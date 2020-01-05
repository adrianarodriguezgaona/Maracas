using Microsoft.EntityFrameworkCore.Migrations;

namespace MaracasMusic.API.Migrations
{
    public partial class fotolinkchange3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "Foto",
                value: "scoreMal1.jpeg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "Foto",
                value: "scoreChi2.jpeg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "Foto",
                value: "scoreMal1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "Foto",
                value: "scoreChi2.jpg");
        }
    }
}
