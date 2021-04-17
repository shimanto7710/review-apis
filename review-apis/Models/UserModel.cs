using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace review_apis.Models
{
    public class UserModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        public string PhoneNumber { get; set; }

  
        public string Email { get; set; }

        public string Name { get; set; }

        public int Sex { get; set; }


        public int UserType { get; set; }

        public string Dp { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsFirstTime { get; set; }

        public string FirebaseKey { get; set; }

        public int BadgeId { get; set; }

        public BadgeModel Badge { get; set; }

        public ICollection<RestaurantModel> RestaurantModel { get; set; }
        
        public ICollection<FoodItemModel> FoodItemModel { get; set; }

        public ICollection<ReviewModel> ReviewList { get; set; }
        public int Point { get; internal set; }
    }
}
