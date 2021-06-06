using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieReview.Infra.Migrations
{
    public partial class AddGenreSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "MovieReview",
                table: "Genres",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("dd44e09d-dc35-4a87-adc5-fa44b7fb008c"), DateTime.UtcNow, null, "Ação", DateTime.UtcNow },
                    { new Guid("d96d07a1-12dd-4c59-90e3-f3075ea89878"), DateTime.UtcNow, null, "Aventura", DateTime.UtcNow },
                    { new Guid("b1dc71c5-b0a8-49ea-a920-99c3cbd98adf"), DateTime.UtcNow, null, "Comédia", DateTime.UtcNow },
                    { new Guid("0f9a6dce-96f7-42cc-82f8-933a1b124690"), DateTime.UtcNow, null, "Dança", DateTime.UtcNow },
                    { new Guid("946b1714-58d9-4edb-beb4-4b6d4ca4abc2"), DateTime.UtcNow, null, "Documentário", DateTime.UtcNow },
                    { new Guid("d31cd4e8-52ba-41f6-983a-9bb2405dc11e"), DateTime.UtcNow, null, "Drama", DateTime.UtcNow },
                    { new Guid("41786d05-a046-43d1-9784-87affb7d89d8"), DateTime.UtcNow, null, "Faroeste", DateTime.UtcNow },
                    { new Guid("047c52e3-3d9d-4009-8655-62fcac45013b"), DateTime.UtcNow, null, "Musical", DateTime.UtcNow },
                    { new Guid("ba5b1931-64c2-4eaf-b6cb-4130cd83fd04"), DateTime.UtcNow, null, "Romance", DateTime.UtcNow },
                    { new Guid("f48ffc93-14b9-400c-976d-6bb0b0439763"), DateTime.UtcNow, null, "Suspense", DateTime.UtcNow },
                    { new Guid("32425de6-259f-498d-b8df-92d14b11d450"), DateTime.UtcNow, null, "Terror", DateTime.UtcNow },
                    { new Guid("425f14d5-ebfa-41a1-a8f2-effe37df280c"), DateTime.UtcNow, null, "Thriller", DateTime.UtcNow }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("047c52e3-3d9d-4009-8655-62fcac45013b"));

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0f9a6dce-96f7-42cc-82f8-933a1b124690"));

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("32425de6-259f-498d-b8df-92d14b11d450"));

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("41786d05-a046-43d1-9784-87affb7d89d8"));

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("425f14d5-ebfa-41a1-a8f2-effe37df280c"));

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("946b1714-58d9-4edb-beb4-4b6d4ca4abc2"));

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b1dc71c5-b0a8-49ea-a920-99c3cbd98adf"));

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ba5b1931-64c2-4eaf-b6cb-4130cd83fd04"));

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d31cd4e8-52ba-41f6-983a-9bb2405dc11e"));

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d96d07a1-12dd-4c59-90e3-f3075ea89878"));

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("dd44e09d-dc35-4a87-adc5-fa44b7fb008c"));

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f48ffc93-14b9-400c-976d-6bb0b0439763"));
        }
    }
}
