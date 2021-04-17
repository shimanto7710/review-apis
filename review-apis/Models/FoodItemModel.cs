using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.Models
{
    public class FoodItemModel
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string FoodType { get; set; }

        [Required]
        public bool Verified { get; set; }

        public DateTime CreatedAt { get; set; }

        
        //public int UserId { get; set; }

      
        public UserModel UserModel { get; set; }

        public ICollection<ReviewedIFoodModel> ReviewedIFoodList { get; set; }

    }
}
