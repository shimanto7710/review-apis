using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.Models
{
    public class CommentModel
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Comment { get; set; }

        public DateTime CreatedAt { get; set; }

        //public int UserId { get; set; }

        public UserModel UserModel { get; set; }

        //public int ReviewId { get; set; }

        public ReviewModel ReviewModel { get; set; }

        public ICollection<ReplyModel> ReplyList { get; set; }
        public ICollection<CommentReactionModel> CommentReactionList { get; set; }
    }
}
