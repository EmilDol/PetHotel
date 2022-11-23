using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelEquipmentRenting.Infrastructure.Migrations
{
    public partial class RemovedEndDateFromRentals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Rentals");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Rentals",
                type: "datetime2",
                nullable: true);
        }
    }
}
