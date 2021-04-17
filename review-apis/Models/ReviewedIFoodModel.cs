using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.Models
{
    public class ReviewedIFoodModel
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //[Required]
        //public int FoodItemId { get; set; }

        public FoodItemModel FoodItemModel { get; set; }

        public double Price { get; set; }

        public bool IsRecommended { get; set; }
        
        public bool IsOffer { get; set; }

        public DateTime CreatedAt { get; set; }

        public double PriceRangeStart { get; set; }

        public double PriceRangeEnd { get; set; }

        public double Rating { get; set; }
        
        public ICollection<TagModel> TagList { get; set; }


        public ReviewModel ReviewModel { get; set; }


        
    }
}
