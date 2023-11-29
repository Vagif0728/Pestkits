namespace Petkit.Models
{
    public class BlogTag
    {
        public int Id { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }

        public int TagId { get; set; }

        public Tag Tag { get; set; }
    }
}
