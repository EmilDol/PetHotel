using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp2022.Infrastructure.Migrations
{
    public partial class NotSureWhatEdited20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5257e93-a85e-48b8-a9ee-f891c7db1b47", "AQAAAAEAACcQAAAAEBIcj71+r+SgYmAdOK8A+7s1PjENaHE48cqKSxPPYLeRdvDYcIaxUuyZkgyDhHGuVg==", "687ff342-fb1e-4690-bfeb-e79e891eda04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c72880be-79dc-4d70-b801-e0e4b4d5c72a", "AQAAAAEAACcQAAAAEKoITmdlwn1OFcZyyijtlOuN5Dg67GUltzDaqyoe7ZvsBT5DASb0hugLX2XgACU5gw==", "ebdc345c-4e99-4e84-aa47-6947e16ac6f4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
