namespace Reddit2.Model
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public List<Vote> Votes { get; set; }

    }
}
