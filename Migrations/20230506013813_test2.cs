using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bellusBibliotheca2.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StylingTool_Products_SkincareItemSerial",
                table: "StylingTool");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_products",
                table: "products",
                column: "Serial");

            migrationBuilder.AddForeignKey(
                name: "FK_StylingTool_products_SkincareItemSerial",
                table: "StylingTool",
                column: "SkincareItemSerial",
                principalTable: "products",
                principalColumn: "Serial");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StylingTool_products_SkincareItemSerial",
                table: "StylingTool");

            migrationBuilder.DropPrimaryKey(
                name: "PK_products",
                table: "products");

            migrationBuilder.RenameTable(
                name: "products",
                newName: "Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Serial");

            migrationBuilder.AddForeignKey(
                name: "FK_StylingTool_Products_SkincareItemSerial",
                table: "StylingTool",
                column: "SkincareItemSerial",
                principalTable: "Products",
                principalColumn: "Serial");
        }
    }
}
