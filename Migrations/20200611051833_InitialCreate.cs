using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalPresents.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Festivals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Festivals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleForUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleForUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Presents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    RoleId = table.Column<int>(nullable: false),
                    GenderId = table.Column<int>(nullable: false),
                    ProfessionId = table.Column<int>(nullable: false),
                    InterestId = table.Column<int>(nullable: false),
                    FestivalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Presents_Festivals_FestivalId",
                        column: x => x.FestivalId,
                        principalTable: "Festivals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Presents_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Presents_Interests_InterestId",
                        column: x => x.InterestId,
                        principalTable: "Interests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Presents_Professions_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "Professions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Presents_RoleForUsers_RoleId",
                        column: x => x.RoleId,
                        principalTable: "RoleForUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    PresentsId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Baskets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Present = table.Column<string>(nullable: true),
                    Count = table.Column<int>(nullable: false),
                    PresentsId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Adress = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    PaymentId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Festivals",
                columns: new[] { "Id", "Name" },
                values: new object[] { 16, "Doesn't matter" });

            migrationBuilder.InsertData(
                table: "Festivals",
                columns: new[] { "Id", "Name" },
                values: new object[] { 15, "Other" });

            migrationBuilder.InsertData(
                table: "Festivals",
                columns: new[] { "Id", "Name" },
                values: new object[] { 14, "1st of September" });

            migrationBuilder.InsertData(
                table: "Festivals",
                columns: new[] { "Id", "Name" },
                values: new object[] { 13, "To visit" });

            migrationBuilder.InsertData(
                table: "Festivals",
                columns: new[] { "Id", "Name" },
                values: new object[] { 11, "Housewarming" });

            migrationBuilder.InsertData(
                table: "Festivals",
                columns: new[] { "Id", "Name" },
                values: new object[] { 10, "High school graduation" });

            migrationBuilder.InsertData(
                table: "Festivals",
                columns: new[] { "Id", "Name" },
                values: new object[] { 9, "Wedding anniversary" });

            migrationBuilder.InsertData(
                table: "Festivals",
                columns: new[] { "Id", "Name" },
                values: new object[] { 8, "Valentine's Day" });

            migrationBuilder.InsertData(
                table: "Festivals",
                columns: new[] { "Id", "Name" },
                values: new object[] { 12, "Birth of a child" });

            migrationBuilder.InsertData(
                table: "Festivals",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Anniversary" });

            migrationBuilder.InsertData(
                table: "Festivals",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Happy Birhtday" });

            migrationBuilder.InsertData(
                table: "Festivals",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Teacher's Day" });

            migrationBuilder.InsertData(
                table: "Festivals",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "8th of March" });

            migrationBuilder.InsertData(
                table: "Festivals",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "23rd of February" });

            migrationBuilder.InsertData(
                table: "Festivals",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "New Year" });

            migrationBuilder.InsertData(
                table: "Festivals",
                columns: new[] { "Id", "Name" },
                values: new object[] { 7, "Wedding" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Man" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Woman" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Doesn't matter" });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Athlete" });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Hunter/fisherman" });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Geek" });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "Name" },
                values: new object[] { 7, "For home" });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "Name" },
                values: new object[] { 8, "Other" });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Cars" });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Traveler" });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Fan" });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "cash" });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "card" });

            migrationBuilder.InsertData(
                table: "Professions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 14, "Doesn't matter" });

            migrationBuilder.InsertData(
                table: "Professions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 13, "Other" });

            migrationBuilder.InsertData(
                table: "Professions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 12, "LawOfficer" });

            migrationBuilder.InsertData(
                table: "Professions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 11, "Sailor" });

            migrationBuilder.InsertData(
                table: "Professions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 10, "Oilman" });

            migrationBuilder.InsertData(
                table: "Professions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 9, "Military" });

            migrationBuilder.InsertData(
                table: "Professions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 8, "Accountant" });

            migrationBuilder.InsertData(
                table: "Professions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Teacher" });

            migrationBuilder.InsertData(
                table: "Professions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Builder" });

            migrationBuilder.InsertData(
                table: "Professions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "ITSpecialist" });

            migrationBuilder.InsertData(
                table: "Professions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Trainer" });

            migrationBuilder.InsertData(
                table: "Professions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Doctor" });

            migrationBuilder.InsertData(
                table: "Professions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Driver" });

            migrationBuilder.InsertData(
                table: "Professions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 7, "Lawyer" });

            migrationBuilder.InsertData(
                table: "RoleForUsers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 15, "Doesn't matter" });

            migrationBuilder.InsertData(
                table: "RoleForUsers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 14, "Other" });

            migrationBuilder.InsertData(
                table: "RoleForUsers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 13, "Сolleague" });

            migrationBuilder.InsertData(
                table: "RoleForUsers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 12, "Boss" });

            migrationBuilder.InsertData(
                table: "RoleForUsers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 11, "Friend" });

            migrationBuilder.InsertData(
                table: "RoleForUsers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 10, "Girlfriend" });

            migrationBuilder.InsertData(
                table: "RoleForUsers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 9, "Boyfriend" });

            migrationBuilder.InsertData(
                table: "RoleForUsers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Grandfather" });

            migrationBuilder.InsertData(
                table: "RoleForUsers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 7, "Wife" });

            migrationBuilder.InsertData(
                table: "RoleForUsers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Grandmother" });

            migrationBuilder.InsertData(
                table: "RoleForUsers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Sister" });

            migrationBuilder.InsertData(
                table: "RoleForUsers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Brother" });

            migrationBuilder.InsertData(
                table: "RoleForUsers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Father" });

            migrationBuilder.InsertData(
                table: "RoleForUsers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Mother" });

            migrationBuilder.InsertData(
                table: "RoleForUsers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 8, "Husbend" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "RoleId" },
                values: new object[] { 1, "admin@mail.ru", "123456", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_UserId",
                table: "Baskets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentId",
                table: "Orders",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Presents_FestivalId",
                table: "Presents",
                column: "FestivalId");

            migrationBuilder.CreateIndex(
                name: "IX_Presents_GenderId",
                table: "Presents",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Presents_InterestId",
                table: "Presents",
                column: "InterestId");

            migrationBuilder.CreateIndex(
                name: "IX_Presents_ProfessionId",
                table: "Presents",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Presents_RoleId",
                table: "Presents",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Presents");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Festivals");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "RoleForUsers");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
