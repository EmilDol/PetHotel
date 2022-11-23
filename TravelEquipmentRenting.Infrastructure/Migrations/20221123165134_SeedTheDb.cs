using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelEquipmentRenting.Infrastructure.Migrations
{
    public partial class SeedTheDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b5a5f2d-6779-4d92-a323-b73d299e1a26", "AQAAAAEAACcQAAAAEPGIhrJ3I3efCQMmn/KR7iav1xkXRaRLM9YbajRrCb1wMASL0+GAjtuOqmKqcwufHg==", "6980b9e3-d80c-4bed-acd6-637c265bf43f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df5ff70c-16dd-49a3-abb0-20c31f907f6c", "AQAAAAEAACcQAAAAEJS0VvS+BNTP9EHcnWHQvk4SYXeZzx45nt9kdnrC6IOjpcP3Q0k6ggc77pqON2vGfA==", "8598268b-cf52-4a5a-b49f-2aeb83795343" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"),
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2022, 11, 23, 16, 51, 33, 694, DateTimeKind.Utc).AddTicks(2753), "Gianluigi Donnarumma Giancarlito PinocchLorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 23, 16, 51, 33, 694, DateTimeKind.Utc).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e97af452-0689-46a0-8739-04a880b25286"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 23, 16, 51, 33, 694, DateTimeKind.Utc).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: new Guid("46b1c11e-dbd0-432a-9bbc-b9cf6d6adfd4"),
                column: "StartDate",
                value: new DateTime(2022, 11, 23, 16, 51, 33, 694, DateTimeKind.Utc).AddTicks(2998));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72d6b611-0e3b-4302-b821-0dc81a1ba86e", "AQAAAAEAACcQAAAAEBGHWg2prZc2jM8KFVPUlmpMBlSR/BPlC4KHosBueYLVYrOz/St0aIhzeq1deZ+Flg==", "052366f9-5a6b-4f8c-9786-74b4810e75a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e51b3f77-a8ed-47ad-9197-10abab646cd4", "AQAAAAEAACcQAAAAEP/r1O1J3lnienx3TqC+nWAX8EkrbvO9mPz5LaF4kMhHArZMindc4wDNUkmuPqv0Ag==", "730c624a-4a92-4097-af19-611a7353f9a0" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"),
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2022, 11, 23, 16, 49, 38, 549, DateTimeKind.Utc).AddTicks(267), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96d4e994-9559-48cb-b9c1-8eb77a96099b"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 23, 16, 49, 38, 549, DateTimeKind.Utc).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e97af452-0689-46a0-8739-04a880b25286"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 23, 16, 49, 38, 549, DateTimeKind.Utc).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: new Guid("46b1c11e-dbd0-432a-9bbc-b9cf6d6adfd4"),
                column: "StartDate",
                value: new DateTime(2022, 11, 23, 16, 49, 38, 549, DateTimeKind.Utc).AddTicks(574));
        }
    }
}
