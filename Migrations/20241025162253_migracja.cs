using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Serwis.Migrations
{
    /// <inheritdoc />
    public partial class migracja : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Klienci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Imie = table.Column<string>(type: "TEXT", nullable: true),
                    Nazwisko = table.Column<string>(type: "TEXT", nullable: true),
                    Telefon = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klienci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Serwisy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: true),
                    Opis = table.Column<string>(type: "TEXT", nullable: true),
                    DataZgloszenia = table.Column<DateTime>(type: "TEXT", nullable: false),
                    KlientId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serwisy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Serwisy_Klienci_KlientId",
                        column: x => x.KlientId,
                        principalTable: "Klienci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Naprawy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Opis = table.Column<string>(type: "TEXT", nullable: true),
                    Koszt = table.Column<decimal>(type: "TEXT", nullable: false),
                    DataNaprawy = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SerwisId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Naprawy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Naprawy_Serwisy_SerwisId",
                        column: x => x.SerwisId,
                        principalTable: "Serwisy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sprzety",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: true),
                    Model = table.Column<string>(type: "TEXT", nullable: true),
                    SerwisId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprzety", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sprzety_Serwisy_SerwisId",
                        column: x => x.SerwisId,
                        principalTable: "Serwisy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Naprawy_SerwisId",
                table: "Naprawy",
                column: "SerwisId");

            migrationBuilder.CreateIndex(
                name: "IX_Serwisy_KlientId",
                table: "Serwisy",
                column: "KlientId");

            migrationBuilder.CreateIndex(
                name: "IX_Sprzety_SerwisId",
                table: "Sprzety",
                column: "SerwisId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Naprawy");

            migrationBuilder.DropTable(
                name: "Sprzety");

            migrationBuilder.DropTable(
                name: "Serwisy");

            migrationBuilder.DropTable(
                name: "Klienci");
        }
    }
}
