﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cityProvinceMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    ProvinceCode = table.Column<string>(type: "TEXT", nullable: false),
                    ProvinceName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.ProvinceCode);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CityName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Population = table.Column<int>(type: "INTEGER", nullable: false),
                    ProvinceCode = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_City_Province_ProvinceCode",
                        column: x => x.ProvinceCode,
                        principalTable: "Province",
                        principalColumn: "ProvinceCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[,]
                {
                    { "AB", "Alberta" },
                    { "BC", "British Columbia" },
                    { "ON", "Ontario" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityId", "CityName", "Population", "ProvinceCode" },
                values: new object[,]
                {
                    { 1, "Vancouver", 631486, "BC" },
                    { 2, "Victoria", 85792, "BC" },
                    { 3, "Kelowna", 127380, "BC" },
                    { 4, "Edmonton", 932546, "AB" },
                    { 5, "Calgary", 1239220, "AB" },
                    { 6, "Red Deer", 100418, "AB" },
                    { 7, "Toronto", 2731571, "ON" },
                    { 8, "Ottawa", 934243, "ON" },
                    { 9, "Hamilton", 536917, "ON" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_City_ProvinceCode",
                table: "City",
                column: "ProvinceCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Province");
        }
    }
}
