using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShop.PointOfSale.Migrations
{
    /// <inheritdoc />
    public partial class addprice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");
        }
    }
}
