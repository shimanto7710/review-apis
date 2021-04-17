using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.Models
{
    public class ReviewModel
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public ICollection<ImageModel> ImageList { get; set; }

        public ICollection<ReviewedIFoodModel> ReviewedFoodList { get; set; }
        public ICollection<ReactionModel> ReactionList { get; set; }
        public ICollection<CommentModel> CommentList { get; set; }

        //public int ReviewRestaurantId { get; set; }

        public ReviewedRestaurantModel ReviewedRestaurantModel { get; set; }

        public int IsReview { get; set; }

        public DateTime CreatedAt { get; set;}

        //public int UserId { get; set; }

        public UserModel UserModel { get; set; }


    }
}
