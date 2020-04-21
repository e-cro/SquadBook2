using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadBook.Data
{
    public class Reply
    {
        //public Comment ReplyComment { get; set; }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        //[Required]
        //public UserAccount Author { get; set; }

        // public Post CommentPost { get; set; }

        public int CommentId { get; set; }
        [ForeignKey(nameof(CommentId))]
        public virtual Comment Comment { get; set; }
        //public int CommentId { get; set; }

        //[ForeignKey(nameof(CommentId))]
        //public virtual Comment Comment { get; set; }
    }
}
