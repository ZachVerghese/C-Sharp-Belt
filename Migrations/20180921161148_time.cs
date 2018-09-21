using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Belt.Migrations
{
    public partial class time : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Email = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Activites",
                columns: table => new
                {
                    ActivityId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CreatorId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Duration = table.Column<TimeSpan>(nullable: false),
                    Time = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Units = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activites", x => x.ActivityId);
                    table.ForeignKey(
                        name: "FK_Activites_Users_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    GuestId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ActivityId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.GuestId);
                    table.ForeignKey(
                        name: "FK_Links_Activites_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activites",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Links_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activites_CreatorId",
                table: "Activites",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_ActivityId",
                table: "Links",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_UserId",
                table: "Links",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "Activites");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
