using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tu_Jardin_App.Server.Migrations
{
    public partial class EmailMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Plants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Seeddate",
                value: new DateTime(2021, 8, 30, 14, 49, 25, 694, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 2,
                column: "Seeddate",
                value: new DateTime(2021, 8, 30, 14, 49, 25, 694, DateTimeKind.Local).AddTicks(4216));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Plants");

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
        }
    }
}
