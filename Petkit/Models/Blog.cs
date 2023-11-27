namespace Petkit.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string? Title { get; set; }
        public DateTime DateTime { get; set; }
        public string? Description { get; set; }
        public int CommentCount { get; set; }
        public string? ImageURL { get; set; }
    }
}
