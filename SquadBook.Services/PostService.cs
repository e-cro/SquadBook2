using SquadBook.Data;
using SquadBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadBook.Services
{
    public class PostService
    {
        private readonly Guid _userId;

        public PostService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreatePost(PostCreate model)
        {
            var entity =
                new Post()
                {
                    UserAccountId = _userId,
                    Title = model.Title,
                    Text = model.Text,
                    
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Posts.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<PostListItem> GetPosts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Posts
                        .Where(e => e.UserAccountId == _userId)
                        .Select(
                            e =>
                                new PostListItem
                                {
                                    PostId = e.Id,
                                    Title = e.Title,
                                    
                                }
                        );

                return query.ToArray();
            }
        }
    }
}
