using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TattooWeb.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddArtistSpecialtyEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"ALTER TABLE ""Artists"" ALTER COLUMN ""Specialty"" TYPE integer USING NULL;");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Specialty",
                table: "Artists",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);
        }
    }
}
