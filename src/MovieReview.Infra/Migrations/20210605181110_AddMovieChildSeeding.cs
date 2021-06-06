using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieReview.Infra.Migrations
{
    public partial class AddMovieChildSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "MovieReview",
                table: "MovieActors",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("f10ed5dc-6ed2-4c13-9403-df769238ef7c"), new Guid("2dfa3862-7bcf-44c7-a9b1-a5a42ee13123") },
                    { new Guid("0585180d-4b05-4a4a-adfb-be571939354f"), new Guid("7b01ccad-21b0-4d52-9c27-b291813a3e54") },
                    { new Guid("f98dc22f-5a0c-4d95-922c-637209140ef1"), new Guid("8cff0471-6d15-4eb6-aebc-a2d43188ce59") },
                    { new Guid("b76c3b43-f46b-4605-9808-e9ce2c157050"), new Guid("445c98ce-7022-4528-8442-c2675183c280") },
                    { new Guid("4552b2e8-d777-4526-aaf8-bc8d460a6eeb"), new Guid("955cc101-848d-4304-855a-f309b104660b") }
                });

            migrationBuilder.InsertData(
                schema: "MovieReview",
                table: "MovieDirectors",
                columns: new[] { "DirectorId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("ab263d6b-09c1-4c00-ae99-eb8af3198b3c"), new Guid("2dfa3862-7bcf-44c7-a9b1-a5a42ee13123") },
                    { new Guid("83b0fd46-de27-45ca-b02c-bbd5e12717b5"), new Guid("7b01ccad-21b0-4d52-9c27-b291813a3e54") },
                    { new Guid("c43e7cdd-c626-43ac-8b31-337f1a0f855a"), new Guid("8cff0471-6d15-4eb6-aebc-a2d43188ce59") },
                    { new Guid("0ca3fe26-18ea-407b-8cd7-f74aeb60077f"), new Guid("445c98ce-7022-4528-8442-c2675183c280") },
                    { new Guid("e9594e43-9c98-4eb4-abc7-5e102341ee47"), new Guid("955cc101-848d-4304-855a-f309b104660b") }
                });

            migrationBuilder.InsertData(
                schema: "MovieReview",
                table: "MovieGenres",
                columns: new[] { "GenreId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("d31cd4e8-52ba-41f6-983a-9bb2405dc11e"), new Guid("2dfa3862-7bcf-44c7-a9b1-a5a42ee13123") },
                    { new Guid("d31cd4e8-52ba-41f6-983a-9bb2405dc11e"), new Guid("7b01ccad-21b0-4d52-9c27-b291813a3e54") },
                    { new Guid("d31cd4e8-52ba-41f6-983a-9bb2405dc11e"), new Guid("8cff0471-6d15-4eb6-aebc-a2d43188ce59") },
                    { new Guid("d31cd4e8-52ba-41f6-983a-9bb2405dc11e"), new Guid("445c98ce-7022-4528-8442-c2675183c280") },
                    { new Guid("ba5b1931-64c2-4eaf-b6cb-4130cd83fd04"), new Guid("955cc101-848d-4304-855a-f309b104660b") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("0585180d-4b05-4a4a-adfb-be571939354f"), new Guid("7b01ccad-21b0-4d52-9c27-b291813a3e54") });

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("4552b2e8-d777-4526-aaf8-bc8d460a6eeb"), new Guid("955cc101-848d-4304-855a-f309b104660b") });

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("b76c3b43-f46b-4605-9808-e9ce2c157050"), new Guid("445c98ce-7022-4528-8442-c2675183c280") });

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("f10ed5dc-6ed2-4c13-9403-df769238ef7c"), new Guid("2dfa3862-7bcf-44c7-a9b1-a5a42ee13123") });

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("f98dc22f-5a0c-4d95-922c-637209140ef1"), new Guid("8cff0471-6d15-4eb6-aebc-a2d43188ce59") });

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "MovieDirectors",
                keyColumns: new[] { "DirectorId", "MovieId" },
                keyValues: new object[] { new Guid("0ca3fe26-18ea-407b-8cd7-f74aeb60077f"), new Guid("445c98ce-7022-4528-8442-c2675183c280") });

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "MovieDirectors",
                keyColumns: new[] { "DirectorId", "MovieId" },
                keyValues: new object[] { new Guid("83b0fd46-de27-45ca-b02c-bbd5e12717b5"), new Guid("7b01ccad-21b0-4d52-9c27-b291813a3e54") });

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "MovieDirectors",
                keyColumns: new[] { "DirectorId", "MovieId" },
                keyValues: new object[] { new Guid("ab263d6b-09c1-4c00-ae99-eb8af3198b3c"), new Guid("2dfa3862-7bcf-44c7-a9b1-a5a42ee13123") });

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "MovieDirectors",
                keyColumns: new[] { "DirectorId", "MovieId" },
                keyValues: new object[] { new Guid("c43e7cdd-c626-43ac-8b31-337f1a0f855a"), new Guid("8cff0471-6d15-4eb6-aebc-a2d43188ce59") });

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "MovieDirectors",
                keyColumns: new[] { "DirectorId", "MovieId" },
                keyValues: new object[] { new Guid("e9594e43-9c98-4eb4-abc7-5e102341ee47"), new Guid("955cc101-848d-4304-855a-f309b104660b") });

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("ba5b1931-64c2-4eaf-b6cb-4130cd83fd04"), new Guid("955cc101-848d-4304-855a-f309b104660b") });

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("d31cd4e8-52ba-41f6-983a-9bb2405dc11e"), new Guid("2dfa3862-7bcf-44c7-a9b1-a5a42ee13123") });

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("d31cd4e8-52ba-41f6-983a-9bb2405dc11e"), new Guid("445c98ce-7022-4528-8442-c2675183c280") });

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("d31cd4e8-52ba-41f6-983a-9bb2405dc11e"), new Guid("7b01ccad-21b0-4d52-9c27-b291813a3e54") });

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("d31cd4e8-52ba-41f6-983a-9bb2405dc11e"), new Guid("8cff0471-6d15-4eb6-aebc-a2d43188ce59") });
        }
    }
}
