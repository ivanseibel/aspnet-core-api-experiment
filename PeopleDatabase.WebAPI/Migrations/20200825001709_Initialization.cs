using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroPessoas.WebAPI.Migrations
{
    public partial class Initialization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "IsActive", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(1984, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "marta@email.com", "Marta", true, "Kent", "33225555" },
                    { 2, new DateTime(1992, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "paula@email.com", "Paula", true, "Isabela", "3354288" },
                    { 3, new DateTime(1977, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "laura@email.com", "Laura", true, "Antonia", "55668899" },
                    { 4, new DateTime(1957, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luiza@email.com", "Luiza", true, "Maria", "6565659" },
                    { 5, new DateTime(2000, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "lucas@email.com", "Lucas", true, "Machado", "565685415" },
                    { 6, new DateTime(2005, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "pedro@email.com", "Pedro", true, "Alvares", "456454545" },
                    { 7, new DateTime(1988, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "paulo@email.com", "Paulo", true, "José", "9874512" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
