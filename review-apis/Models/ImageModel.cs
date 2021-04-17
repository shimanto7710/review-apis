using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.Models
{
    public class ImageModel
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Url { get; set; }

        
        public DateTime CreatedAt { get; set; }

        public string Caption { get; set; }

        [Required]
        //public int ReviewId { get; set; }

        public ReviewModel ReviewModel { get; set; }
    }
}
