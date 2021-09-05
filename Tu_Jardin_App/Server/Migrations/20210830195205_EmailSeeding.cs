using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tu_Jardin_App.Server.Migrations
{
    public partial class EmailSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Seeddate" },
                values: new object[] { "estebanlopezb2010@gmail.com", new DateTime(2021, 8, 30, 14, 52, 4, 851, DateTimeKind.Local).AddTicks(4392) });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Seeddate" },
                values: new object[] { "estebanlopezb2010@gmail.com", new DateTime(2021, 8, 30, 14, 52, 4, 851, DateTimeKind.Local).AddTicks(8003) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Seeddate" },
                values: new object[] { null, new DateTime(2021, 8, 30, 14, 49, 25, 694, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Seeddate" },
                values: new object[] { null, new DateTime(2021, 8, 30, 14, 49, 25, 694, DateTimeKind.Local).AddTicks(4216) });
        }
    }
}
