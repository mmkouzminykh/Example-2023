using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Example.Migrations
{
    /// <inheritdoc />
    public partial class PriceRenewal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PriceRenewal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RenewalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceRenewal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RenewalDetail",
                columns: table => new
                {
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    PriceRenewalId = table.Column<int>(type: "int", nullable: false),
                    NewPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RenewalDetail", x => new { x.PropertyId, x.PriceRenewalId });
                    table.ForeignKey(
                        name: "FK_RenewalDetail_PriceRenewal_PriceRenewalId",
                        column: x => x.PriceRenewalId,
                        principalTable: "PriceRenewal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RenewalDetail_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RenewalDetail_PriceRenewalId",
                table: "RenewalDetail",
                column: "PriceRenewalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RenewalDetail");

            migrationBuilder.DropTable(
                name: "PriceRenewal");
        }
    }
}
