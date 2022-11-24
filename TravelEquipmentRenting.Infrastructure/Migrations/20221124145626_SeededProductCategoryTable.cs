using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelEquipmentRenting.Infrastructure.Migrations
{
    public partial class SeededProductCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "ProductsCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("39a87631-5fc3-4c14-b96f-dec2408600a5"), new Guid("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3") },
                    { new Guid("39a87631-5fc3-4c14-b96f-dec2408600a5"), new Guid("e97af452-0689-46a0-8739-04a880b25286") },
                    { new Guid("ae9f7553-eaae-45fe-8e15-12ec6187f980"), new Guid("96d4e994-9559-48cb-b9c1-8eb77a96099b") },
                    { new Guid("ae9f7553-eaae-45fe-8e15-12ec6187f980"), new Guid("e97af452-0689-46a0-8739-04a880b25286") },
                    { new Guid("fed5527f-721f-43b7-ba3e-8d4160cc714c"), new Guid("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3") }
                });

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: new Guid("46b1c11e-dbd0-432a-9bbc-b9cf6d6adfd4"),
                column: "StartDate",
                value: new DateTime(2022, 11, 24, 14, 56, 26, 402, DateTimeKind.Utc).AddTicks(9038));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductsCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("39a87631-5fc3-4c14-b96f-dec2408600a5"), new Guid("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3") });

            migrationBuilder.DeleteData(
                table: "ProductsCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("39a87631-5fc3-4c14-b96f-dec2408600a5"), new Guid("e97af452-0689-46a0-8739-04a880b25286") });

            migrationBuilder.DeleteData(
                table: "ProductsCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("ae9f7553-eaae-45fe-8e15-12ec6187f980"), new Guid("96d4e994-9559-48cb-b9c1-8eb77a96099b") });

            migrationBuilder.DeleteData(
                table: "ProductsCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("ae9f7553-eaae-45fe-8e15-12ec6187f980"), new Guid("e97af452-0689-46a0-8739-04a880b25286") });

            migrationBuilder.DeleteData(
                table: "ProductsCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("fed5527f-721f-43b7-ba3e-8d4160cc714c"), new Guid("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d28f9a5d-586b-4207-a0ce-8a9b15e11c8d", "AQAAAAEAACcQAAAAEFcnwmXhlmsPkIk1KMHpvmQgEWXc/VeJMscqy72mN9DLGm3fbqZfKQBnXMIrJAnRmw==", "f0e7ec02-514d-4968-9879-ee6b0077d7d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffc4950f-ed98-46f9-808c-2dc7a652f1d8", "AQAAAAEAACcQAAAAEA8GWpCZbPcYZNiw93/NnbQXTgxH5n0s6+Mg3MboWYqL7BYaOMJEWC74SM/HAdH6Zw==", "26556fb7-8264-4534-96a8-ef822b1745c5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 24, 14, 51, 23, 565, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 24, 14, 51, 23, 565, DateTimeKind.Utc).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e97af452-0689-46a0-8739-04a880b25286"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 24, 14, 51, 23, 565, DateTimeKind.Utc).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: new Guid("46b1c11e-dbd0-432a-9bbc-b9cf6d6adfd4"),
                column: "StartDate",
                value: new DateTime(2022, 11, 24, 14, 51, 23, 565, DateTimeKind.Utc).AddTicks(8740));
        }
    }
}
