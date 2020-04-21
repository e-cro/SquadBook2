using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadBook.Models
{
    public class CommentListItem
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }

    }
}
