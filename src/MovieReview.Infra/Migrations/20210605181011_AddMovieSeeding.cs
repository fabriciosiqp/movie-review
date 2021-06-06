using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieReview.Infra.Migrations
{
    public partial class AddMovieSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "MovieReview",
                table: "Movies",
                columns: new[] { "Id", "AgeClassification", "CreatedAt", "DateRelease", "DeletedAt", "Summary", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2dfa3862-7bcf-44c7-a9b1-a5a42ee13123"), 0, DateTime.UtcNow, new DateTime(2007, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chris enfrenta sérios problemas financeiros e Linda, sua esposa, decide partir. Ele agora é pai solteiro e precisa cuidar de Christopher, seu filho de 5 anos. ", "À Procura da Felicidade", DateTime.UtcNow },
                    { new Guid("7b01ccad-21b0-4d52-9c27-b291813a3e54"), 14, DateTime.UtcNow, new DateTime(1994, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mesmo com o raciocínio lento, Forrest Gump nunca se sentiu desfavorecido. Graças ao apoio da mãe, ele teve uma vida normal.", "Forrest Gump - O Contador de Histórias", DateTime.UtcNow },
                    { new Guid("8cff0471-6d15-4eb6-aebc-a2d43188ce59"), 16, DateTime.UtcNow, new DateTime(1995, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Andy Dufresne é condenado a duas prisões perpétuas consecutivas pelas mortes de sua esposa e de seu amante. ", "Um Sonho de Liberdade", DateTime.UtcNow },
                    { new Guid("445c98ce-7022-4528-8442-c2675183c280"), 16, DateTime.UtcNow, new DateTime(1987, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "O soldado Davis, batizado de 'Joker' pelo sargento linha-dura Hartman, suporta os rigores do treinamento básico e tenta ajudar o ridicularizado colega Lawrence.", "Nascido para Matar", DateTime.UtcNow },
                    { new Guid("955cc101-848d-4304-855a-f309b104660b"), 16, DateTime.UtcNow, new DateTime(2004, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Joel se surpreende ao saber que seu amor verdadeiro, Clementine, o apagou completamente de sua memória. Ele decide fazer o mesmo, mas muda de ideia.", "Brilho Eterno de uma Mente sem Lembranças", DateTime.UtcNow }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2dfa3862-7bcf-44c7-a9b1-a5a42ee13123"));

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("445c98ce-7022-4528-8442-c2675183c280"));

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7b01ccad-21b0-4d52-9c27-b291813a3e54"));

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("8cff0471-6d15-4eb6-aebc-a2d43188ce59"));

            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("955cc101-848d-4304-855a-f309b104660b"));
        }
    }
}
