using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tu_Jardin_App.Server.Migrations
{
    public partial class UserSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Seeddate",
                value: new DateTime(2021, 8, 28, 13, 13, 9, 742, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 2,
                column: "Seeddate",
                value: new DateTime(2021, 8, 28, 13, 13, 9, 743, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Img", "Plants", "Points", "UserName" },
                values: new object[,]
                {
                    { 1, "test@gmail.com", "/images/logros/agricultor.png", 2, 230, "Dave Herrera" },
                    { 2, "test2@gmail.com", "/images/logros/guardabosques.png", 3, 150, "Solnarux" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Seeddate",
                value: new DateTime(2021, 8, 28, 13, 1, 27, 950, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 2,
                column: "Seeddate",
                value: new DateTime(2021, 8, 28, 13, 1, 27, 950, DateTimeKind.Local).AddTicks(9289));
        }
    }
}
