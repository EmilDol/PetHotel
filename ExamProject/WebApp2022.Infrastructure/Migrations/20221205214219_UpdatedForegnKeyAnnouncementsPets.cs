using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp2022.Infrastructure.Migrations
{
    public partial class UpdatedForegnKeyAnnouncementsPets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Announcements_PetId",
                table: "Announcements");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e55bc6e6-c703-4cb2-9ad9-e7e219a9c9d5", "AQAAAAEAACcQAAAAEIgFRtxhpmVIwN6JbGmY4t6S+YDDh+IFUUsRU2ReTmutq7VqNYZFXn7GAM30G8qQVQ==", "0aacb180-9f6f-40b0-aefd-5ff9f07177a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "135ef753-4df9-4504-97b9-66410ad91694", "AQAAAAEAACcQAAAAEIdAANCPO8uvC0LMSTUqim6BWijDTpwUNm8CZX8D3V9e8QBouGP9rJqSZdzUmCze5g==", "36506439-b00a-4e3b-816e-71316250cf3e" });

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_PetId",
                table: "Announcements",
                column: "PetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Announcements_PetId",
                table: "Announcements");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2360ff9-5553-4f9d-8a53-3c0e2ef28945", "AQAAAAEAACcQAAAAEFOanxyXAW8LKnldknZVO1HW7NTrWhC8eNdovrQsptFY4n2KmChI5y35jJeRpkrmXg==", "9e6592fc-6833-4e03-91a6-a9834951c7ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7f6f4bd-224e-4141-9760-c8543b23b257", "AQAAAAEAACcQAAAAEP21DUpzXOK1fnGZkwrXRuqgQr0JyLns1QzEyFUxFzYwLle6bn8rLfslBKNrKiEzoQ==", "2150b132-7520-4b19-9343-c761cb9acdb9" });

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_PetId",
                table: "Announcements",
                column: "PetId",
                unique: true);
        }
    }
}
