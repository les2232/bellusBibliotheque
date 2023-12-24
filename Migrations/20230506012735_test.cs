using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bellusBibliotheca2.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "StylingTool");

            migrationBuilder.DropColumn(
                name: "City",
                table: "StylingTool");

            migrationBuilder.DropColumn(
                name: "CountryID",
                table: "StylingTool");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "StylingTool");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "StylingTool");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "StylingTool");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "StylingTool");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "StylingTool",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "PostalCode",
                table: "StylingTool",
                newName: "BrandName");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "StylingTool",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "BrandName",
                table: "StylingTool",
                newName: "PostalCode");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "StylingTool",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "StylingTool",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CountryID",
                table: "StylingTool",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "StylingTool",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "StylingTool",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "StylingTool",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "StylingTool",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(8,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
