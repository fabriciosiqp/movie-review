using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieReview.Infra.Migrations
{
    public partial class AddActorSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "MovieReview",
                table: "Actors",
                columns: new[] { "Id", "Biography", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("f10ed5dc-6ed2-4c13-9403-df769238ef7c"), "é um ator, rapper, produtor cinematográfico, produtor musical e produtor de televisão americano.", DateTime.UtcNow, null, "Will Smith", DateTime.UtcNow },
                    { new Guid("0585180d-4b05-4a4a-adfb-be571939354f"), "é um ator e cineasta norte-americano. Destacou-se em diversos filmes de sucesso.", DateTime.UtcNow, null, "Tom Hanks", DateTime.UtcNow },
                    { new Guid("f98dc22f-5a0c-4d95-922c-637209140ef1"), "é um premiado ator, produtor, narrador e cineasta estadunidense.", DateTime.UtcNow, null, "Morgan Freeman", DateTime.UtcNow },
                    { new Guid("b76c3b43-f46b-4605-9808-e9ce2c157050"), "é um ator estadunidense. Estudou no Actors Studio e no American Stanislavski Theatre.", DateTime.UtcNow, null, "Vicent D'Onofrio", DateTime.UtcNow },
                    { new Guid("4552b2e8-d777-4526-aaf8-bc8d460a6eeb"), "James Eugene 'Jim' Carrey é um ator, comediante, dublador, roteirista, produtor e pintor canadense.", DateTime.UtcNow, null, "Jim Carray", DateTime.UtcNow }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("0585180d-4b05-4a4a-adfb-be571939354f"));

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("4552b2e8-d777-4526-aaf8-bc8d460a6eeb"));

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("b76c3b43-f46b-4605-9808-e9ce2c157050"));

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("f10ed5dc-6ed2-4c13-9403-df769238ef7c"));

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("f98dc22f-5a0c-4d95-922c-637209140ef1"));
        }
    }
}
