using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.Models
{
    public class ActivityModel
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int UserId { get; set; }

        public UserModel UserModel { get; set; }

        public string Msg { get; set; }

        public DateTime CreatedAt { get; set; }

        public int UserIdTo { get; set; }

        public int UserIdFrom { get; set; }

        public bool IsSeen { get; set; }
    }
}
