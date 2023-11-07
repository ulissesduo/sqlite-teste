using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SQLiteTeste.Migrations
{
    /// <inheritdoc />
    public partial class newtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbFood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FoodN = table.Column<int>(type: "INTEGER", nullable: false),
                    FoodR = table.Column<int>(type: "INTEGER", nullable: false),
                    FoodP = table.Column<int>(type: "INTEGER", nullable: false),
                    Chicken = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbFood", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbWater",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Water = table.Column<int>(type: "INTEGER", nullable: false),
                    WaterDrank = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbWater", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbFood");

            migrationBuilder.DropTable(
                name: "tbWater");
        }
    }
}
