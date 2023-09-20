using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class OneToManyRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "books",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "books",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "ISBN",
                table: "books",
                newName: "isbn");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "books",
                newName: "book_id");

            migrationBuilder.AddColumn<int>(
                name: "publisher_id",
                table: "books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 1,
                column: "publisher_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 2,
                column: "publisher_id",
                value: 2);

            migrationBuilder.InsertData(
                table: "publisher",
                columns: new[] { "publisher_id", "location", "name" },
                values: new object[,]
                {
                    { 1, "Iasi", "Editura Litera" },
                    { 2, "Bucuresti", "Editura Curtea Veche" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_books_publisher_id",
                table: "books",
                column: "publisher_id");

            migrationBuilder.AddForeignKey(
                name: "FK_books_publisher_publisher_id",
                table: "books",
                column: "publisher_id",
                principalTable: "publisher",
                principalColumn: "publisher_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_publisher_publisher_id",
                table: "books");

            migrationBuilder.DropIndex(
                name: "IX_books_publisher_id",
                table: "books");

            migrationBuilder.DeleteData(
                table: "publisher",
                keyColumn: "publisher_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "publisher",
                keyColumn: "publisher_id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "publisher_id",
                table: "books");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "books",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "books",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "isbn",
                table: "books",
                newName: "ISBN");

            migrationBuilder.RenameColumn(
                name: "book_id",
                table: "books",
                newName: "BookId");
        }
    }
}
