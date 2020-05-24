using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TerminoLo.Data.Migrations
{
    public partial class TermDBS001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Begriffe",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Hauptbenennung = table.Column<string>(maxLength: 100, nullable: true),
                    TagListe = table.Column<string>(maxLength: 500, nullable: true),
                    Bemerkungen = table.Column<string>(maxLength: 1000, nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Begriffe", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Begriffe");
        }
    }
}
