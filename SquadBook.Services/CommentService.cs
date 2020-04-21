using SquadBook.Data;
using SquadBook.Models.Comment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadBook.Services
{
    public class CommentService
    {
        private readonly int _postId;

        public CommentService(int postId)
        {
            _postId = postId;
        }

        public bool CreateComment(CommentCreate model)
        {
            var entity =
                new Comment()
                {
                    PostId = _postId,
                    Text = model.Text,
                   
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Comments.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        //public IEnumerable<NoteListItem> GetNotes()
        //{
        //    using (var ctx = new ApplicationDbContext())
        //    {
        //        var query =
        //            ctx
        //                .Notes
        //                .Where(e => e.OwnerId == _userId)
        //                .Select(
        //                    e =>
        //                        new NoteListItem
        //                        {
        //                            NoteId = e.NoteId,
        //                            Title = e.Title,
        //                            CreatedUtc = e.CreatedUtc
        //                        }
        //                );

        //        return query.ToArray();
        //    }
        //}
    }
}
