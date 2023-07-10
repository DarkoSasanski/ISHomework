using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieTickets.Web.Data.Migrations
{
    public partial class addedmovieentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieDescription",
                table: "MovieTickets");

            migrationBuilder.DropColumn(
                name: "MovieImage",
                table: "MovieTickets");

            migrationBuilder.DropColumn(
                name: "MovieName",
                table: "MovieTickets");

            migrationBuilder.DropColumn(
                name: "MovieRating",
                table: "MovieTickets");

            migrationBuilder.AddColumn<Guid>(
                name: "MovieId",
                table: "MovieTickets",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieRating = table.Column<double>(type: "float", nullable: false),
                    MovieGenre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieTickets_MovieId",
                table: "MovieTickets",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieTickets_Movie_MovieId",
                table: "MovieTickets",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieTickets_Movie_MovieId",
                table: "MovieTickets");

            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_MovieTickets_MovieId",
                table: "MovieTickets");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "MovieTickets");

            migrationBuilder.AddColumn<string>(
                name: "MovieDescription",
                table: "MovieTickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MovieImage",
                table: "MovieTickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MovieName",
                table: "MovieTickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "MovieRating",
                table: "MovieTickets",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
