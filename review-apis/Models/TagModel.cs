using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.Models
{
    public class TagModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public bool Verified { get; set; }

        public DateTime CreatedAt { get; set; }

        public ICollection<ReviewedIFoodModel> ReviewedIFoodList { get; set; }

       // public int TagId { get; set; }

       // public ReviewedIFoodModel ReviewedIFoodModel { get; set; }

       // public int UserId { get; set; }


       // public string UserModel { get; set; }


    }
}
