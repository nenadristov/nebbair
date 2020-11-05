using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NebbAir.Migrations
{
    public partial class initalispravka : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patnici",
                columns: table => new
                {
                    PatnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: false),
                    Prezime = table.Column<string>(nullable: false),
                    DataNaRagjanje = table.Column<DateTime>(nullable: false),
                    PassporNo = table.Column<string>(nullable: false),
                    FlightNo = table.Column<string>(nullable: false),
                    Origin = table.Column<string>(nullable: false),
                    Destination = table.Column<string>(nullable: false),
                    Departure = table.Column<DateTime>(nullable: false),
                    Return = table.Column<DateTime>(nullable: false),
                    CarryOn = table.Column<int>(nullable: false),
                    Trolley = table.Column<int>(nullable: false),
                    CheckIn = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patnici", x => x.PatnikID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patnici");
        }
    }
}
