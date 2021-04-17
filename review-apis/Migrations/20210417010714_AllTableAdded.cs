using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace review_apis.Migrations
{
    public partial class AllTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Badge",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Point = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Badge", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FollowModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FollowingUserId = table.Column<int>(type: "int", nullable: false),
                    FollowerUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TagModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Verified = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    Dp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsFirstTime = table.Column<bool>(type: "bit", nullable: false),
                    FirebaseKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BadgeId = table.Column<int>(type: "int", nullable: false),
                    Point = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Badge_BadgeId",
                        column: x => x.BadgeId,
                        principalTable: "Badge",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActivityModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserModelId = table.Column<int>(type: "int", nullable: true),
                    Msg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserIdTo = table.Column<int>(type: "int", nullable: false),
                    UserIdFrom = table.Column<int>(type: "int", nullable: false),
                    IsSeen = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityModel_User_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FoodItemModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Verified = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodItemModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodItemModel_User_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Verified = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestaurantModel_User_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReviewedRestaurantModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicingRating = table.Column<double>(type: "float", nullable: false),
                    EnvironmentgRating = table.Column<double>(type: "float", nullable: false),
                    DecorationRating = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    RestaurantModelId = table.Column<int>(type: "int", nullable: true),
                    IsRooftop = table.Column<bool>(type: "bit", nullable: false),
                    IsBuffet = table.Column<bool>(type: "bit", nullable: false),
                    IsPlayZoon = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewedRestaurantModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReviewedRestaurantModel_RestaurantModel_RestaurantModelId",
                        column: x => x.RestaurantModelId,
                        principalTable: "RestaurantModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReviewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewRestaurantId = table.Column<int>(type: "int", nullable: false),
                    ReviewedRestaurantModelId = table.Column<int>(type: "int", nullable: true),
                    IsReview = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReviewModel_ReviewedRestaurantModel_ReviewedRestaurantModelId",
                        column: x => x.ReviewedRestaurantModelId,
                        principalTable: "ReviewedRestaurantModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReviewModel_User_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CommentModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserModelId = table.Column<int>(type: "int", nullable: true),
                    ReviewId = table.Column<int>(type: "int", nullable: false),
                    ReviewModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentModel_ReviewModel_ReviewModelId",
                        column: x => x.ReviewModelId,
                        principalTable: "ReviewModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommentModel_User_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImageModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewId = table.Column<int>(type: "int", nullable: false),
                    ReviewModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageModel_ReviewModel_ReviewModelId",
                        column: x => x.ReviewModelId,
                        principalTable: "ReviewModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReactionModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserModelId = table.Column<int>(type: "int", nullable: true),
                    IsLike = table.Column<bool>(type: "bit", nullable: false),
                    IsHelpful = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReviewId = table.Column<int>(type: "int", nullable: false),
                    ReviewModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReactionModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReactionModel_ReviewModel_ReviewModelId",
                        column: x => x.ReviewModelId,
                        principalTable: "ReviewModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReactionModel_User_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReviewedIFoodModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodItemId = table.Column<int>(type: "int", nullable: false),
                    FoodItemModelId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    IsRecommended = table.Column<bool>(type: "bit", nullable: false),
                    IsOffer = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PriceRangeStart = table.Column<double>(type: "float", nullable: false),
                    PriceRangeEnd = table.Column<double>(type: "float", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    ReviewModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewedIFoodModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReviewedIFoodModel_FoodItemModel_FoodItemModelId",
                        column: x => x.FoodItemModelId,
                        principalTable: "FoodItemModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReviewedIFoodModel_ReviewModel_ReviewModelId",
                        column: x => x.ReviewModelId,
                        principalTable: "ReviewModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CommentReactionModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserModelId = table.Column<int>(type: "int", nullable: true),
                    IsLike = table.Column<bool>(type: "bit", nullable: false),
                    IsHelpful = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CommentId = table.Column<int>(type: "int", nullable: false),
                    CommentModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentReactionModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentReactionModel_CommentModel_CommentModelId",
                        column: x => x.CommentModelId,
                        principalTable: "CommentModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommentReactionModel_User_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReplyModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserModelId = table.Column<int>(type: "int", nullable: true),
                    CommentId = table.Column<int>(type: "int", nullable: false),
                    CommentModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReplyModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReplyModel_CommentModel_CommentModelId",
                        column: x => x.CommentModelId,
                        principalTable: "CommentModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReplyModel_User_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReviewedIFoodModelTagModel",
                columns: table => new
                {
                    ReviewedIFoodListId = table.Column<int>(type: "int", nullable: false),
                    TagListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewedIFoodModelTagModel", x => new { x.ReviewedIFoodListId, x.TagListId });
                    table.ForeignKey(
                        name: "FK_ReviewedIFoodModelTagModel_ReviewedIFoodModel_ReviewedIFoodListId",
                        column: x => x.ReviewedIFoodListId,
                        principalTable: "ReviewedIFoodModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReviewedIFoodModelTagModel_TagModel_TagListId",
                        column: x => x.TagListId,
                        principalTable: "TagModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReplyReactionModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserModelId = table.Column<int>(type: "int", nullable: true),
                    IsLike = table.Column<bool>(type: "bit", nullable: false),
                    IsHelpful = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReplyId = table.Column<int>(type: "int", nullable: false),
                    ReplyModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReplyReactionModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReplyReactionModel_ReplyModel_ReplyModelId",
                        column: x => x.ReplyModelId,
                        principalTable: "ReplyModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReplyReactionModel_User_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityModel_UserModelId",
                table: "ActivityModel",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentModel_ReviewModelId",
                table: "CommentModel",
                column: "ReviewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentModel_UserModelId",
                table: "CommentModel",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentReactionModel_CommentModelId",
                table: "CommentReactionModel",
                column: "CommentModelId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentReactionModel_UserModelId",
                table: "CommentReactionModel",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodItemModel_UserModelId",
                table: "FoodItemModel",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageModel_ReviewModelId",
                table: "ImageModel",
                column: "ReviewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ReactionModel_ReviewModelId",
                table: "ReactionModel",
                column: "ReviewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ReactionModel_UserModelId",
                table: "ReactionModel",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplyModel_CommentModelId",
                table: "ReplyModel",
                column: "CommentModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplyModel_UserModelId",
                table: "ReplyModel",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplyReactionModel_ReplyModelId",
                table: "ReplyReactionModel",
                column: "ReplyModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplyReactionModel_UserModelId",
                table: "ReplyReactionModel",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantModel_UserModelId",
                table: "RestaurantModel",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewedIFoodModel_FoodItemModelId",
                table: "ReviewedIFoodModel",
                column: "FoodItemModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewedIFoodModel_ReviewModelId",
                table: "ReviewedIFoodModel",
                column: "ReviewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewedIFoodModelTagModel_TagListId",
                table: "ReviewedIFoodModelTagModel",
                column: "TagListId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewedRestaurantModel_RestaurantModelId",
                table: "ReviewedRestaurantModel",
                column: "RestaurantModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewModel_ReviewedRestaurantModelId",
                table: "ReviewModel",
                column: "ReviewedRestaurantModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewModel_UserModelId",
                table: "ReviewModel",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_User_BadgeId",
                table: "User",
                column: "BadgeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityModel");

            migrationBuilder.DropTable(
                name: "CommentReactionModel");

            migrationBuilder.DropTable(
                name: "FollowModel");

            migrationBuilder.DropTable(
                name: "ImageModel");

            migrationBuilder.DropTable(
                name: "Profile");

            migrationBuilder.DropTable(
                name: "ReactionModel");

            migrationBuilder.DropTable(
                name: "ReplyReactionModel");

            migrationBuilder.DropTable(
                name: "ReviewedIFoodModelTagModel");

            migrationBuilder.DropTable(
                name: "ReplyModel");

            migrationBuilder.DropTable(
                name: "ReviewedIFoodModel");

            migrationBuilder.DropTable(
                name: "TagModel");

            migrationBuilder.DropTable(
                name: "CommentModel");

            migrationBuilder.DropTable(
                name: "FoodItemModel");

            migrationBuilder.DropTable(
                name: "ReviewModel");

            migrationBuilder.DropTable(
                name: "ReviewedRestaurantModel");

            migrationBuilder.DropTable(
                name: "RestaurantModel");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Badge");
        }
    }
}
