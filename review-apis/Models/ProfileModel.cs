using System;
using System.ComponentModel.DataAnnotations;

namespace review_apis.Models
{
    public class ProfileModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string UserName { get; set; }
    }
}
