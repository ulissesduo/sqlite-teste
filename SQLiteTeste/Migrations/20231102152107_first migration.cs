using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SQLiteTeste.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbDogTreatments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Food = table.Column<int>(type: "INTEGER", nullable: false),
                    MissingFood = table.Column<int>(type: "INTEGER", nullable: false),
                    Water = table.Column<int>(type: "INTEGER", nullable: false),
                    MissingWater = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDogTreatments", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbDogTreatments");
        }
    }
}
