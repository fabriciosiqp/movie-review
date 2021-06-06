using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieReview.Infra.Migrations
{
    public partial class AddUserSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "MovieReview",
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "Name", "Password", "IsAdmin", "UpdatedAt" },
                values: new object[] { new Guid("dcffe995-f5b4-4806-b96d-8ca6211cfe8e"), DateTime.UtcNow, null, "admin@admin.com", "Administrador", "4D693211BCDEF83ED934CB46B2152FB3749CFAA980180A7D13B1246F4E11689F3A4FC925A4B42A32BDADA021481D3E11908DF2EC61A44C03F9CE37F2E724DE47", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "MovieReview",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dcffe995-f5b4-4806-b96d-8ca6211cfe8e"));
        }
    }
}
