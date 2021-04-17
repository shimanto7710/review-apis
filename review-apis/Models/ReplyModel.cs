using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.Models
{
    public class ReplyModel
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Reply { get; set; }

        public DateTime CreatedAt { get; set; }

        //public int UserId { get; set; }

        public UserModel UserModel { get; set; }

       // public int CommentId { get; set; }

        public CommentModel CommentModel { get; set; }

        public ICollection<ReplyReactionModel> ReplyReactionList { get; set; }

    }
}
