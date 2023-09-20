using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableColumnsNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "genres");

            migrationBuilder.RenameColumn(
                name: "GenreName",
                table: "genres",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "DisplayOrder",
                table: "genres",
                newName: "display_order");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "genres",
                newName: "genre_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_genres",
                table: "genres",
                column: "genre_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_genres",
                table: "genres");

            migrationBuilder.RenameTable(
                name: "genres",
                newName: "Genres");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Genres",
                newName: "GenreName");

            migrationBuilder.RenameColumn(
                name: "display_order",
                table: "Genres",
                newName: "DisplayOrder");

            migrationBuilder.RenameColumn(
                name: "genre_id",
                table: "Genres",
                newName: "GenreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "GenreId");
        }
    }
}
