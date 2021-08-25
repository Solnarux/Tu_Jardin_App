using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tu_Jardin_App.Server.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plants_Achieves_AchievementsId",
                table: "Plants");

            migrationBuilder.AlterColumn<int>(
                name: "AchievementsId",
                table: "Plants",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Achieves",
                columns: new[] { "Id", "Agricultor", "Cosecha", "Guardabosques", "Hermitano", "Jardin", "Jardinero", "Lluvia", "Riego", "Semillero", "Vida" },
                values: new object[] { 1, true, false, false, false, false, false, false, false, true, false });

            migrationBuilder.InsertData(
                table: "Achieves",
                columns: new[] { "Id", "Agricultor", "Cosecha", "Guardabosques", "Hermitano", "Jardin", "Jardinero", "Lluvia", "Riego", "Semillero", "Vida" },
                values: new object[] { 2, false, true, false, false, false, false, false, true, false, false });

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "Id", "AchievementsId", "Img", "Name", "Owner", "Seeddate", "Type" },
                values: new object[] { 1, 1, "/images/Aromáticas.png", "Jesus", "David Herrera", new DateTime(2021, 8, 25, 11, 53, 23, 357, DateTimeKind.Local).AddTicks(4578), "Salvia" });

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "Id", "AchievementsId", "Img", "Name", "Owner", "Seeddate", "Type" },
                values: new object[] { 2, 2, "/images/Cannabis.png", "Alberto", "David Herrera", new DateTime(2021, 8, 25, 11, 53, 23, 357, DateTimeKind.Local).AddTicks(8685), "Cannabis Indica" });

            migrationBuilder.AddForeignKey(
                name: "FK_Plants_Achieves_AchievementsId",
                table: "Plants",
                column: "AchievementsId",
                principalTable: "Achieves",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plants_Achieves_AchievementsId",
                table: "Plants");

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Achieves",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Achieves",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "AchievementsId",
                table: "Plants",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Plants_Achieves_AchievementsId",
                table: "Plants",
                column: "AchievementsId",
                principalTable: "Achieves",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
