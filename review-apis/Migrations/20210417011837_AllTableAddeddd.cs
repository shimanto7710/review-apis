using Microsoft.EntityFrameworkCore.Migrations;

namespace review_apis.Migrations
{
    public partial class AllTableAddeddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageModel_ReviewModel_ReviewModelId",
                table: "ImageModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ReviewedRestaurantModel_RestaurantModel_RestaurantModelId",
                table: "ReviewedRestaurantModel");

            migrationBuilder.DropColumn(
                name: "ReviewRestaurantId",
                table: "ReviewModel");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ReviewModel");

            migrationBuilder.DropColumn(
                name: "RestaurantId",
                table: "ReviewedRestaurantModel");

            migrationBuilder.DropColumn(
                name: "FoodItemId",
                table: "ReviewedIFoodModel");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "RestaurantModel");

            migrationBuilder.DropColumn(
                name: "ReplyId",
                table: "ReplyReactionModel");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ReplyReactionModel");

            migrationBuilder.DropColumn(
                name: "CommentId",
                table: "ReplyModel");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ReplyModel");

            migrationBuilder.DropColumn(
                name: "ReviewId",
                table: "ReactionModel");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ReactionModel");

            migrationBuilder.DropColumn(
                name: "ReviewId",
                table: "ImageModel");

            migrationBuilder.DropColumn(
                name: "FollowerUserId",
                table: "FollowModel");

            migrationBuilder.DropColumn(
                name: "FollowingUserId",
                table: "FollowModel");

            migrationBuilder.DropColumn(
                name: "CommentId",
                table: "CommentReactionModel");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CommentReactionModel");

            migrationBuilder.DropColumn(
                name: "ReviewId",
                table: "CommentModel");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CommentModel");

            migrationBuilder.AlterColumn<int>(
                name: "RestaurantModelId",
                table: "ReviewedRestaurantModel",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReviewModelId",
                table: "ImageModel",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FollowerUserIdId",
                table: "FollowModel",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FollowingUserIdId",
                table: "FollowModel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FollowModel_FollowerUserIdId",
                table: "FollowModel",
                column: "FollowerUserIdId");

            migrationBuilder.CreateIndex(
                name: "IX_FollowModel_FollowingUserIdId",
                table: "FollowModel",
                column: "FollowingUserIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_FollowModel_User_FollowerUserIdId",
                table: "FollowModel",
                column: "FollowerUserIdId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FollowModel_User_FollowingUserIdId",
                table: "FollowModel",
                column: "FollowingUserIdId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ImageModel_ReviewModel_ReviewModelId",
                table: "ImageModel",
                column: "ReviewModelId",
                principalTable: "ReviewModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewedRestaurantModel_RestaurantModel_RestaurantModelId",
                table: "ReviewedRestaurantModel",
                column: "RestaurantModelId",
                principalTable: "RestaurantModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FollowModel_User_FollowerUserIdId",
                table: "FollowModel");

            migrationBuilder.DropForeignKey(
                name: "FK_FollowModel_User_FollowingUserIdId",
                table: "FollowModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ImageModel_ReviewModel_ReviewModelId",
                table: "ImageModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ReviewedRestaurantModel_RestaurantModel_RestaurantModelId",
                table: "ReviewedRestaurantModel");

            migrationBuilder.DropIndex(
                name: "IX_FollowModel_FollowerUserIdId",
                table: "FollowModel");

            migrationBuilder.DropIndex(
                name: "IX_FollowModel_FollowingUserIdId",
                table: "FollowModel");

            migrationBuilder.DropColumn(
                name: "FollowerUserIdId",
                table: "FollowModel");

            migrationBuilder.DropColumn(
                name: "FollowingUserIdId",
                table: "FollowModel");

            migrationBuilder.AddColumn<int>(
                name: "ReviewRestaurantId",
                table: "ReviewModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ReviewModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "RestaurantModelId",
                table: "ReviewedRestaurantModel",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "RestaurantId",
                table: "ReviewedRestaurantModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FoodItemId",
                table: "ReviewedIFoodModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "RestaurantModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReplyId",
                table: "ReplyReactionModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ReplyReactionModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CommentId",
                table: "ReplyModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ReplyModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReviewId",
                table: "ReactionModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ReactionModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ReviewModelId",
                table: "ImageModel",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ReviewId",
                table: "ImageModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FollowerUserId",
                table: "FollowModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FollowingUserId",
                table: "FollowModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CommentId",
                table: "CommentReactionModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "CommentReactionModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReviewId",
                table: "CommentModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "CommentModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ImageModel_ReviewModel_ReviewModelId",
                table: "ImageModel",
                column: "ReviewModelId",
                principalTable: "ReviewModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewedRestaurantModel_RestaurantModel_RestaurantModelId",
                table: "ReviewedRestaurantModel",
                column: "RestaurantModelId",
                principalTable: "RestaurantModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
