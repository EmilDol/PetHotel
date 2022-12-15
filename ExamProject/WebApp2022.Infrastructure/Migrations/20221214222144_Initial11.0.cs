using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp2022.Infrastructure.Migrations
{
    public partial class Initial110 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Towns",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TownId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Towns_TownId",
                        column: x => x.TownId,
                        principalTable: "Towns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReceiverId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Requirements = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Heigth = table.Column<double>(type: "float", nullable: false),
                    Weigth = table.Column<double>(type: "float", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pets_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OfferedPaying = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    DayStarting = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DayEnding = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Announcements_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BabysitterId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AnnouncementId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_Announcements_AnnouncementId",
                        column: x => x.AnnouncementId,
                        principalTable: "Announcements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_AspNetUsers_BabysitterId",
                        column: x => x.BabysitterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("651dc286-24dd-473e-8099-a56ad3e7a6e2"), "Sofia" });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "IsApproved", "Name" },
                values: new object[,]
                {
                    { new Guid("658cfb89-2396-438d-baea-c10ef9ba492f"), true, "Veliko Tarnovo" },
                    { new Guid("6fb2fef5-b16e-49dd-bfc4-8aef199df54c"), true, "Pavlikeni" },
                    { new Guid("d3e30c24-857f-4cd0-ba75-b9accb4d7c9f"), true, "Lovech" }
                });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("d6ce7d29-6f17-478d-af2f-b45fb212dd02"), "Plovdiv" });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "IsApproved", "Name" },
                values: new object[] { new Guid("db7127bc-1d68-4b3b-a523-a68a78b7e4a8"), true, "Pleven" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsAvailable", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TownId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "0e1a0da9-d610-4170-806d-4b97c086d137", "guest1@mail.com", false, "Ivan", false, "Georgiev", false, null, "GUEST1@MAIL.COM", "GUEST1", "AQAAAAEAACcQAAAAEHwNU3ZOdRtY1LE1Ilyuw8KnhXADXXyVBZtg06V3s9UJh+2hiAJK422qQI+24k+6Zg==", "0884305667", false, "8067ef5b-eb0b-4387-a7ee-4377bbf1a3ba", new Guid("658cfb89-2396-438d-baea-c10ef9ba492f"), false, "guest1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsAvailable", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TownId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "72153552-7b85-4e34-b236-290e9bbad012", 0, "eee25b04-55ce-4a3e-bc87-f54fa97d1fb1", "guest2@mail.com", false, "Boyan", false, "Hristov", false, null, "GUEST2@MAIL.COM", "GUEST2", "AQAAAAEAACcQAAAAEGFvhVctu3igf51tljwV5B/CLP8yX9JwAedYBq1arD4G5u9OsnjewP1fkQJiBSRArw==", "0854993215", false, "121031f2-3337-49be-b2a3-58f4774b6ff8", new Guid("658cfb89-2396-438d-baea-c10ef9ba492f"), false, "guest2" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsAvailable", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TownId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dea12856-c198-4129-b3f3-b893d8395082", 0, "bf7afff5-d0dc-416e-83fc-01d89b1d5eb9", "admin@mail.com", false, "Petar", false, "Petrov", false, null, " ADMIN@MAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEM/i+9bvA8dzSoGxb5IXlMJ89jVZDXUmkWGFZVVeSt6CZ+ttvuNYa3hYI01K3hpoiQ==", "0882854999", false, "64bc7e30-be93-42bc-8104-b3aff3e80db0", new Guid("658cfb89-2396-438d-baea-c10ef9ba492f"), false, "admin" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AuthorId", "Content", "ReceiverId", "Title" },
                values: new object[,]
                {
                    { new Guid("21fd2544-3246-48bb-be99-9981c44c8836"), "72153552-7b85-4e34-b236-290e9bbad012", "Very good babysitter for pets. Would recommend if you need a babysitter for a couple of days!", "dea12856-c198-4129-b3f3-b893d8395082", "Great babysitter" },
                    { new Guid("2892e4f0-4e16-4323-8f7c-076bcc74579e"), "dea12856-c198-4129-b3f3-b893d8395082", "He returned my cat ill and starving! He had beaten up my cat!", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", "Worst babysitter" },
                    { new Guid("6f49aa38-a113-4f20-a077-9208099578ae"), "dea12856-c198-4129-b3f3-b893d8395082", "He didn't just watch after my parrot, but even taugth him new words and songs!", "72153552-7b85-4e34-b236-290e9bbad012", "Can't complain" },
                    { new Guid("b09e19e1-e970-47cc-ac48-c3f9d6bc6426"), "dea12856-c198-4129-b3f3-b893d8395082", "I hired Ivan to watch after my gold fish, but he killed it! He is a terrible babysitter!", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", "Don't recommend" }
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Age", "DateAdded", "Description", "Heigth", "ImageUrl", "Name", "OwnerId", "Requirements", "Type", "Weigth" },
                values: new object[] { new Guid("38237218-53e9-413e-ade3-49b4a122922f"), 42, new DateTime(2022, 12, 14, 22, 21, 44, 491, DateTimeKind.Utc).AddTicks(3620), "Horsey. She big and likes balconies. She the beloved wife of Juan", 2.8500000000000001, "https://i.redd.it/4kc2skyohqx51.jpg", "Juanita", "72153552-7b85-4e34-b236-290e9bbad012", "Every evening she needs to hear her husband Juan", 2, 300.0 });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Age", "DateAdded", "Description", "Heigth", "ImageUrl", "IsApproved", "Name", "OwnerId", "Requirements", "Type", "Weigth" },
                values: new object[,]
                {
                    { new Guid("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3"), 3, new DateTime(2022, 12, 14, 22, 21, 44, 491, DateTimeKind.Utc).AddTicks(3606), "Gianluigi Donnarumma Giancarlito PinocchLorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the", 0.29999999999999999, "https://media.istockphoto.com/id/537373196/photo/trees-forming-a-heart.jpg?s=612x612&w=0&k=20&c=onZKNjkycICe4q2ZDnKi39z42Ax9tpZT7pph-2e5Seo=", true, "Mishi", "dea12856-c198-4129-b3f3-b893d8395082", "Needs to be played with and weekly beautition session", 1, 4.0 },
                    { new Guid("96d4e994-9559-48cb-b9c1-8eb77a96099b"), 69, new DateTime(2022, 12, 14, 22, 21, 44, 491, DateTimeKind.Utc).AddTicks(3617), "Horsey. He big and likes balconies.", 3.0, "https://i.kym-cdn.com/entries/icons/original/000/035/644/juancover.jpg", true, "Juan", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", "He needs immediate access to every balcony in perementar of 1 km and to to his wife Juanita", 3, 420.0 }
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Age", "DateAdded", "Description", "Heigth", "ImageUrl", "Name", "OwnerId", "Requirements", "Type", "Weigth" },
                values: new object[] { new Guid("e97af452-0689-46a0-8739-04a880b25286"), 36, new DateTime(2022, 12, 14, 22, 21, 44, 491, DateTimeKind.Utc).AddTicks(3612), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has", 1.5, "https://www.apple.com/newsroom/images/product/iphone/lifestyle/Apple-Shot-on-iPhone-macro-Guido-Cassanelli_inline.jpg.large.jpg", "Pablo", "72153552-7b85-4e34-b236-290e9bbad012", "Every second full noon he goes to Tsvetelina Yaneva's concert", 6, 5.0 });

            migrationBuilder.InsertData(
                table: "Announcements",
                columns: new[] { "Id", "DayEnding", "DayStarting", "IsAvailable", "OfferedPaying", "PetId" },
                values: new object[] { new Guid("15d01d36-951f-4599-a747-a4a4fd38d7b4"), new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 150m, new Guid("96d4e994-9559-48cb-b9c1-8eb77a96099b") });

            migrationBuilder.InsertData(
                table: "Announcements",
                columns: new[] { "Id", "DayEnding", "DayStarting", "IsAvailable", "OfferedPaying", "PetId" },
                values: new object[] { new Guid("7c712e77-a568-415c-ad7f-10ab554cd6e4"), new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3000m, new Guid("96d4e994-9559-48cb-b9c1-8eb77a96099b") });

            migrationBuilder.InsertData(
                table: "Announcements",
                columns: new[] { "Id", "DayEnding", "DayStarting", "IsAvailable", "OfferedPaying", "PetId" },
                values: new object[] { new Guid("a8f31fcf-57af-432a-9f2e-c6856ee41031"), new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 400m, new Guid("4b8ec921-8cd7-4020-bbc3-e31e6d40aee3") });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "AnnouncementId", "BabysitterId", "IsConfirmed" },
                values: new object[] { new Guid("00ff1a5f-8b2f-4b84-999e-e524da8f461a"), new Guid("15d01d36-951f-4599-a747-a4a4fd38d7b4"), "dea12856-c198-4129-b3f3-b893d8395082", true });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "AnnouncementId", "BabysitterId" },
                values: new object[,]
                {
                    { new Guid("01f39c0e-1b4a-4200-9469-094175666e4d"), new Guid("a8f31fcf-57af-432a-9f2e-c6856ee41031"), "72153552-7b85-4e34-b236-290e9bbad012" },
                    { new Guid("52cfc479-066a-4772-94f0-c24826f9b357"), new Guid("7c712e77-a568-415c-ad7f-10ab554cd6e4"), "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" },
                    { new Guid("f0207fe1-af72-48de-88c3-28e76f33f588"), new Guid("7c712e77-a568-415c-ad7f-10ab554cd6e4"), "dea12856-c198-4129-b3f3-b893d8395082" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_PetId",
                table: "Announcements",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TownId",
                table: "AspNetUsers",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ReceiverId",
                table: "Comments",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_OwnerId",
                table: "Pets",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_AnnouncementId",
                table: "Requests",
                column: "AnnouncementId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_BabysitterId",
                table: "Requests",
                column: "BabysitterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Towns");
        }
    }
}
