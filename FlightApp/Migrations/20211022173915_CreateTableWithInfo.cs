using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FlightApp.Migrations
{
    public partial class CreateTableWithInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    FlightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FlightDuration = table.Column<float>(type: "real", nullable: false),
                    Departure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.FlightId);
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "Departure", "Destination", "FlightDate", "FlightDuration" },
                values: new object[] { 1, "Chisinau", "Tokyo", new DateTime(2009, 5, 8, 14, 40, 52, 0, DateTimeKind.Unspecified), 7.7f });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "Departure", "Destination", "FlightDate", "FlightDuration" },
                values: new object[] { 2, "Washington", "New York", new DateTime(2019, 12, 12, 17, 55, 14, 0, DateTimeKind.Unspecified), 2.2f });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "Departure", "Destination", "FlightDate", "FlightDuration" },
                values: new object[] { 3, "Moscow", "Bucharest", new DateTime(2021, 1, 7, 5, 6, 7, 0, DateTimeKind.Unspecified), 3f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flights");
        }
    }
}
