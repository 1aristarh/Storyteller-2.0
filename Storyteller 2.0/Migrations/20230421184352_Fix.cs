using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Storyteller_2._0.Migrations
{
    /// <inheritdoc />
    public partial class Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Comics_ComicId",
                table: "Pages");

            migrationBuilder.RenameColumn(
                name: "ComicId",
                table: "Pages",
                newName: "PageId");

            migrationBuilder.RenameIndex(
                name: "IX_Pages_ComicId",
                table: "Pages",
                newName: "IX_Pages_PageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Comics_PageId",
                table: "Pages",
                column: "PageId",
                principalTable: "Comics",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Comics_PageId",
                table: "Pages");

            migrationBuilder.RenameColumn(
                name: "PageId",
                table: "Pages",
                newName: "ComicId");

            migrationBuilder.RenameIndex(
                name: "IX_Pages_PageId",
                table: "Pages",
                newName: "IX_Pages_ComicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Comics_ComicId",
                table: "Pages",
                column: "ComicId",
                principalTable: "Comics",
                principalColumn: "Id");
        }
    }
}
