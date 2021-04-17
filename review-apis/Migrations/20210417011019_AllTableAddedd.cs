using Microsoft.EntityFrameworkCore.Migrations;

namespace review_apis.Migrations
{
    public partial class AllTableAddedd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "FoodItemModel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "FoodItemModel",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
