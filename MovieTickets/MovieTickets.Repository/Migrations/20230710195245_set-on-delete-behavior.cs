using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieTickets.Web.Data.Migrations
{
    public partial class setondeletebehavior : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieTickets_Movies_MovieId",
                table: "MovieTickets");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieTickets_Movies_MovieId",
                table: "MovieTickets",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieTickets_Movies_MovieId",
                table: "MovieTickets");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieTickets_Movies_MovieId",
                table: "MovieTickets",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
