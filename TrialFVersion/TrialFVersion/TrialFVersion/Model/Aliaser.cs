namespace TrialFVersion.Model
{
    public class Aliaser
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public int HitCount { get; set; }
        public int SecretCode { get; set; } = new Random().Next(1000, 9999);
    }
}
