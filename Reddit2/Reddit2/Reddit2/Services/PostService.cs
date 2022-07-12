using Microsoft.EntityFrameworkCore;
using Reddit2.Database;
using Reddit2.Model;

namespace Reddit2.Services
{
    public class PostService
    {
        private ApplicationDbContext context { get; set; }
        public PostService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<Post> GetPosts()
        {
            return context.Posts.Include(p=>p.Votes).ToList();
        }
        public void AddPost(string title,string url)
        {
            var log = new Post { Title = title, Url = url };
            context.Posts.Add(log);
            context.SaveChanges();
        }
        
        public void Vote(int votevalue, int userId, int postId)
        {
            Vote? v = context.Votes.FirstOrDefault(v => v.UserId == userId && v.PostId == postId);

            if (v == null)
            {
                Vote vote = new Vote { VoteValue = votevalue, UserId = userId, PostId = postId };
                context.Votes.Add(vote);
            } else if (v.VoteValue == votevalue)
            {
                context.Votes.Remove(v);
            } else
            {
                v.VoteValue = votevalue;
            }

            context.SaveChanges();
        }

    }
}
