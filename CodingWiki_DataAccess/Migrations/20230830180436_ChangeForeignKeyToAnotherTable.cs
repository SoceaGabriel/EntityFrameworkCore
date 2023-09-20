using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangeForeignKeyToAnotherTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "book_detail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_book_detail_BookId",
                table: "book_detail",
                column: "BookId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_book_detail_books_BookId",
                table: "book_detail",
                column: "BookId",
                principalTable: "books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_book_detail_books_BookId",
                table: "book_detail");

            migrationBuilder.DropIndex(
                name: "IX_book_detail_BookId",
                table: "book_detail");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "book_detail");
        }
    }
}
