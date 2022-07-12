using Reddit2.Model;
using Reddit2.Services;

namespace Reddit2.ViewModel
{
    public class IndexViewModel
    {
        public List<Post> ListOfPosts { get; set; }
        public List<User> ListOfUsers { get; set; }
        public User? CurrentUser { get; set; }
    }
}
