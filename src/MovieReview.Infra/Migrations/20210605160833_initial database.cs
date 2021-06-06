using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieReview.Infra.Migrations
{
    public partial class initialdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "MovieReview");

            migrationBuilder.CreateTable(
                name: "Actors",
                schema: "MovieReview",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Biography = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                schema: "MovieReview",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Biography = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                schema: "MovieReview",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                schema: "MovieReview",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Summary = table.Column<string>(maxLength: 300, nullable: false),
                    AgeClassification = table.Column<int>(nullable: false),
                    DateRelease = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "MovieReview",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    Password = table.Column<string>(maxLength: 128, nullable: false),
                    IsAdmin = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieActors",
                schema: "MovieReview",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(nullable: false),
                    ActorId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieActors", x => new { x.ActorId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_MovieActors_Actors_ActorId",
                        column: x => x.ActorId,
                        principalSchema: "MovieReview",
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovieActors_Movies_MovieId",
                        column: x => x.MovieId,
                        principalSchema: "MovieReview",
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieDirectors",
                schema: "MovieReview",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(nullable: false),
                    DirectorId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieDirectors", x => new { x.DirectorId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_MovieDirectors_Directors_DirectorId",
                        column: x => x.DirectorId,
                        principalSchema: "MovieReview",
                        principalTable: "Directors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovieDirectors_Movies_MovieId",
                        column: x => x.MovieId,
                        principalSchema: "MovieReview",
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieGenres",
                schema: "MovieReview",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(nullable: false),
                    GenreId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieGenres", x => new { x.GenreId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_MovieGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalSchema: "MovieReview",
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovieGenres_Movies_MovieId",
                        column: x => x.MovieId,
                        principalSchema: "MovieReview",
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieVotes",
                schema: "MovieReview",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieVotes", x => new { x.UserId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_MovieVotes_Movies_MovieId",
                        column: x => x.MovieId,
                        principalSchema: "MovieReview",
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovieVotes_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "MovieReview",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieActors_MovieId",
                schema: "MovieReview",
                table: "MovieActors",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieDirectors_MovieId",
                schema: "MovieReview",
                table: "MovieDirectors",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_MovieId",
                schema: "MovieReview",
                table: "MovieGenres",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieVotes_MovieId",
                schema: "MovieReview",
                table: "MovieVotes",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                schema: "MovieReview",
                table: "Users",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieActors",
                schema: "MovieReview");

            migrationBuilder.DropTable(
                name: "MovieDirectors",
                schema: "MovieReview");

            migrationBuilder.DropTable(
                name: "MovieGenres",
                schema: "MovieReview");

            migrationBuilder.DropTable(
                name: "MovieVotes",
                schema: "MovieReview");

            migrationBuilder.DropTable(
                name: "Actors",
                schema: "MovieReview");

            migrationBuilder.DropTable(
                name: "Directors",
                schema: "MovieReview");

            migrationBuilder.DropTable(
                name: "Genres",
                schema: "MovieReview");

            migrationBuilder.DropTable(
                name: "Movies",
                schema: "MovieReview");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "MovieReview");
        }
    }
}
