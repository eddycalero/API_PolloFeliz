using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNI.Models.Migrations
{
    /// <inheritdoc />
    public partial class CODIGOINICIAL2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Is_active",
                schema: "product",
                table: "product",
                newName: "is_active");

            migrationBuilder.AddColumn<bool>(
                name: "is_expirate",
                schema: "product",
                table: "product",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_expirate",
                schema: "product",
                table: "product");

            migrationBuilder.RenameColumn(
                name: "is_active",
                schema: "product",
                table: "product",
                newName: "Is_active");
        }
    }
}
