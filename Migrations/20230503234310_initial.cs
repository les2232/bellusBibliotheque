using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bellusBibliotheca2.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Serial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Serial);
                });

            migrationBuilder.CreateTable(
                name: "StylingTool",
                columns: table => new
                {
                    prodSerial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkincareItemSerial = table.Column<int>(type: "int", nullable: true),
                    StylingToolprodSerial = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StylingTool", x => x.prodSerial);
                    table.ForeignKey(
                        name: "FK_StylingTool_Products_SkincareItemSerial",
                        column: x => x.SkincareItemSerial,
                        principalTable: "Products",
                        principalColumn: "Serial");
                    table.ForeignKey(
                        name: "FK_StylingTool_StylingTool_StylingToolprodSerial",
                        column: x => x.StylingToolprodSerial,
                        principalTable: "StylingTool",
                        principalColumn: "prodSerial");
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Serial", "Brand", "Category", "ExpirationDate", "Name", "Price" },
                values: new object[] { 542977, "avant", "face cleanser", new DateTime(2017, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "blue volcanic stone purifying and antioxidising cleansing gel", 110m });

            migrationBuilder.CreateIndex(
                name: "IX_StylingTool_SkincareItemSerial",
                table: "StylingTool",
                column: "SkincareItemSerial");

            migrationBuilder.CreateIndex(
                name: "IX_StylingTool_StylingToolprodSerial",
                table: "StylingTool",
                column: "StylingToolprodSerial");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StylingTool");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
