namespace Reddit2.Model
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public List<Post> UserPosts { get; set; }
        public List<Vote> UserVotes { get; set; }
    }
}
