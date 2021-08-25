using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tu_Jardin_App.Server.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Achieves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Semillero = table.Column<bool>(type: "bit", nullable: false),
                    Jardin = table.Column<bool>(type: "bit", nullable: false),
                    Vida = table.Column<bool>(type: "bit", nullable: false),
                    Guardabosques = table.Column<bool>(type: "bit", nullable: false),
                    Hermitano = table.Column<bool>(type: "bit", nullable: false),
                    Riego = table.Column<bool>(type: "bit", nullable: false),
                    Lluvia = table.Column<bool>(type: "bit", nullable: false),
                    Cosecha = table.Column<bool>(type: "bit", nullable: false),
                    Agricultor = table.Column<bool>(type: "bit", nullable: false),
                    Jardinero = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achieves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seeddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AchievementsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plants_Achieves_AchievementsId",
                        column: x => x.AchievementsId,
                        principalTable: "Achieves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Plants_AchievementsId",
                table: "Plants",
                column: "AchievementsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plants");

            migrationBuilder.DropTable(
                name: "Achieves");
        }
    }
}
