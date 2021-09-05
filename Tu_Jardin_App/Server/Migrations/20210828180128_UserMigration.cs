using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tu_Jardin_App.Server.Migrations
{
    public partial class UserMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Points = table.Column<int>(type: "int", nullable: false),
                    Plants = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Seeddate",
                value: new DateTime(2021, 8, 25, 11, 53, 23, 357, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 2,
                column: "Seeddate",
                value: new DateTime(2021, 8, 25, 11, 53, 23, 357, DateTimeKind.Local).AddTicks(8685));
        }
    }
}
