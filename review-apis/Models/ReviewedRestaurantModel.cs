using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.Models
{
    public class ReviewedRestaurantModel
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public ICollection<ReviewModel> ReviewList { get; set; }

        public double ServicingRating { get; set; }
        public double EnvironmentgRating { get; set; }
        public double DecorationRating { get; set; }
        public DateTime CreatedAt { get; set; }

        [Required]
        //public int RestaurantId { get; set; }

        public RestaurantModel RestaurantModel { get; set; }

        public bool IsRooftop { get; set; }
        public bool IsBuffet { get; set; }
        public bool IsPlayZoon { get; set; }

    }
}
