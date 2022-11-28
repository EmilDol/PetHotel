using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelEquipmentRenting.Infrastructure.Migrations
{
    public partial class AddedIsApprovedToTownsAndCountries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Towns",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Countries",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "021acf41-ae0c-4063-8ac0-720a92641cdf", "AQAAAAEAACcQAAAAEHKPg4d4OJoIvM1ijF4WTgYXPW8C/CSq8lc/L5JOCWzjtAgSXVuld5SwvoAimw2Aag==", "8fb46ac0-eb1b-4531-9176-37f3552cc33c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9fcae4f-0278-47e1-b5bd-b1aa2b5214d2", "AQAAAAEAACcQAAAAENKOJpyiJIcELkCnlInPEYDqAuGJNANE/xQ5hcr9ZAl1FCO31EaA3Iu6off6Nrdwqg==", "ccf91328-5c69-4fae-8810-522b8e65b9de" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 28, 14, 55, 17, 681, DateTimeKind.Utc).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 28, 14, 55, 17, 681, DateTimeKind.Utc).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e97af452-0689-46a0-8739-04a880b25286"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 28, 14, 55, 17, 681, DateTimeKind.Utc).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: new Guid("46b1c11e-dbd0-432a-9bbc-b9cf6d6adfd4"),
                column: "StartDate",
                value: new DateTime(2022, 11, 28, 14, 55, 17, 681, DateTimeKind.Utc).AddTicks(7588));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Towns");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Countries");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf24a458-33ab-4613-9c43-b0ca633de8fb", "AQAAAAEAACcQAAAAEO8/+hQTdCMKOQJx5Z/2KCdl3XKdk977bTIMYG0HRwvdBZZXV+Ph1JJBhtfSNotY7w==", "69d1b325-cf0b-448e-8317-dccfd6f0f0da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e6f3119-647b-4b2c-8bdb-09e9db727ea0", "AQAAAAEAACcQAAAAENCNDVjJMHIVv9goIvlROtoHxK0XKDKbO1F1ZarYvtzjE6ea6JMB3qV9TD7cZQxJaA==", "d0cdd4f4-f925-49d0-9a97-2449b4d300de" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 24, 14, 56, 26, 402, DateTimeKind.Utc).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 24, 14, 56, 26, 402, DateTimeKind.Utc).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e97af452-0689-46a0-8739-04a880b25286"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 24, 14, 56, 26, 402, DateTimeKind.Utc).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: new Guid("46b1c11e-dbd0-432a-9bbc-b9cf6d6adfd4"),
                column: "StartDate",
                value: new DateTime(2022, 11, 24, 14, 56, 26, 402, DateTimeKind.Utc).AddTicks(9038));
        }
    }
}
