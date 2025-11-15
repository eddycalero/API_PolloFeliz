using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNI.Models.Migrations
{
    /// <inheritdoc />
    public partial class TEST_PRODUCT_RELATION : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "category_id",
                schema: "product",
                table: "subcategory",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "sub_category_id",
                schema: "product",
                table: "product",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "unit_measure_id",
                schema: "product",
                table: "product",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_subcategory_category_id",
                schema: "product",
                table: "subcategory",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_sub_category_id",
                schema: "product",
                table: "product",
                column: "sub_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_unit_measure_id",
                schema: "product",
                table: "product",
                column: "unit_measure_id");

            migrationBuilder.AddForeignKey(
                name: "FK_product_subcategory_sub_category_id",
                schema: "product",
                table: "product",
                column: "sub_category_id",
                principalSchema: "product",
                principalTable: "subcategory",
                principalColumn: "subcategory_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_unit_measure_unit_measure_id",
                schema: "product",
                table: "product",
                column: "unit_measure_id",
                principalSchema: "product",
                principalTable: "unit_measure",
                principalColumn: "unit_measure_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_subcategory_category_category_id",
                schema: "product",
                table: "subcategory",
                column: "category_id",
                principalSchema: "product",
                principalTable: "category",
                principalColumn: "category_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_subcategory_sub_category_id",
                schema: "product",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_product_unit_measure_unit_measure_id",
                schema: "product",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_subcategory_category_category_id",
                schema: "product",
                table: "subcategory");

            migrationBuilder.DropIndex(
                name: "IX_subcategory_category_id",
                schema: "product",
                table: "subcategory");

            migrationBuilder.DropIndex(
                name: "IX_product_sub_category_id",
                schema: "product",
                table: "product");

            migrationBuilder.DropIndex(
                name: "IX_product_unit_measure_id",
                schema: "product",
                table: "product");

            migrationBuilder.DropColumn(
                name: "category_id",
                schema: "product",
                table: "subcategory");

            migrationBuilder.DropColumn(
                name: "sub_category_id",
                schema: "product",
                table: "product");

            migrationBuilder.DropColumn(
                name: "unit_measure_id",
                schema: "product",
                table: "product");
        }
    }
}
