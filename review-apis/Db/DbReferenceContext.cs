using Microsoft.EntityFrameworkCore;

namespace review_apis.Models
{
    public class DbReferenceContext : DbContext
    {
        public DbReferenceContext(DbContextOptions<DbReferenceContext> option) :base (option)
        {
         
        }

        public DbSet<ProfileModel> Profile { get; set; }

        public DbSet<UserModel> User { get; set; }

        public DbSet<BadgeModel> Badge { get; set; }

        public DbSet<RestaurantModel> RestaurantModel { get; set; }

        public DbSet<FoodItemModel> FoodItemModel { get; set; }

        public DbSet<TagModel> TagModel { get; set; }

        public DbSet<ActivityModel> ActivityModel { get; set; }

        public DbSet<CommentModel> CommentModel { get; set; }

        public DbSet<CommentReactionModel> CommentReactionModel { get; set; }

        public DbSet<FollowModel> FollowModel { get; set; }

        public DbSet<ImageModel> ImageModel { get; set; }

        public DbSet<ReactionModel> ReactionModel { get; set; }

        public DbSet<ReplyModel> ReplyModel { get; set; }

        public DbSet<ReplyReactionModel> ReplyReactionModel { get; set; }

        public DbSet<ReviewedIFoodModel> ReviewedIFoodModel { get; set; }

        public DbSet<ReviewedRestaurantModel> ReviewedRestaurantModel { get; set; }

        public DbSet<ReviewModel> ReviewModel { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        /*   protected override void OnModelCreating(DbModelBuilder modelBuilder)
           {

           }*/

    }
}
