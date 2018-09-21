using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Belt.Migrations
{
    public partial class duration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "Activites",
                nullable: false,
                oldClrType: typeof(TimeSpan));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Duration",
                table: "Activites",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
