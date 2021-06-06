using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieReview.Infra.Migrations
{
    public partial class AddDirectorSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "MovieReview",
                table: "Directors",
                columns: new[] { "Id", "Biography", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("ab263d6b-09c1-4c00-ae99-eb8af3198b3c"), "é uma cineasta italiana. Ele trabalhou seu caminho de fazer curtas-metragens apenas exibidos na televisão italiana para se tornar um cineasta americano bem conhecido e bem-sucedido.", DateTime.UtcNow, null, "Gabriele Muccino", DateTime.UtcNow },
                    { new Guid("83b0fd46-de27-45ca-b02c-bbd5e12717b5"), "é um cineasta, produtor e roteirista estadunidense. Sua família é de origem lituana e iugoslava.", DateTime.UtcNow, null, "Robert Zemeckis", DateTime.UtcNow },
                    { new Guid("c43e7cdd-c626-43ac-8b31-337f1a0f855a"), "é um cineasta, roteirista e produtor de cinema francês radicado nos Estados Unidos. Fez várias adaptações dos livros de Stephen King.", DateTime.UtcNow, null, "Frank Darabont", DateTime.UtcNow },
                    { new Guid("0ca3fe26-18ea-407b-8cd7-f74aeb60077f"), "Foi um cineasta, roteirista, produtor e fotógrafo estadunidense. Frequentemente apontado como um dos cineastas mais influentes do cinema", DateTime.UtcNow, null, "Stanley Kubrick", DateTime.UtcNow },
                    { new Guid("e9594e43-9c98-4eb4-abc7-5e102341ee47"), "é um cineasta francês. Dirigiu dois filmes do famoso roteirista Charlie Kaufman, Human Nature e Eternal Sunshine of the Spotless Mind.", DateTime.UtcNow, null, "Michel Gondry", DateTime.UtcNow }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("0ca3fe26-18ea-407b-8cd7-f74aeb60077f"));

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("83b0fd46-de27-45ca-b02c-bbd5e12717b5"));

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("ab263d6b-09c1-4c00-ae99-eb8af3198b3c"));

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("c43e7cdd-c626-43ac-8b31-337f1a0f855a"));

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("e9594e43-9c98-4eb4-abc7-5e102341ee47"));
        }
    }
}
