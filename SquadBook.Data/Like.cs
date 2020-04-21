using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadBook.Data
{
    public class Like
    {
        [Key]
        public int Id { get; set; }

        public int PostId { get; set; }
        [ForeignKey(nameof(PostId))]
        public virtual Post Post { get; set; }

        
        //public Post LikedPost { get; set; }
        //public UserAccount Liker { get; set; }
    }
}
