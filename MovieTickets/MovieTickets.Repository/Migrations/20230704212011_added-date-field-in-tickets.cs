using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieTickets.Web.Data.Migrations
{
    public partial class addeddatefieldintickets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "MovieDateTime",
                table: "MovieTickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieDateTime",
                table: "MovieTickets");
        }
    }
}
