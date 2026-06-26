using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TattooWeb.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUniqueIndexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_clients_cpf",
                table: "clients",
                column: "cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_clients_email",
                table: "clients",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_artists_cpf",
                table: "artists",
                column: "cpf",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_clients_cpf",
                table: "clients");

            migrationBuilder.DropIndex(
                name: "IX_clients_email",
                table: "clients");

            migrationBuilder.DropIndex(
                name: "IX_artists_cpf",
                table: "artists");
        }
    }
}
