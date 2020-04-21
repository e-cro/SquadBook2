using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadBook.Models
{
    public class PostListItem
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
