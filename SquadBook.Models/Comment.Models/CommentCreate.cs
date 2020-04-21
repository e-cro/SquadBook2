using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadBook.Models.Comment.Models
{
    public class CommentCreate
    {
        [Required]
        public string Text { get; set; }
    }
}
