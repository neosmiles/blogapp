using System;

namespace api.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;

        // Navigation Properties
        public Author Author { get; set; }
    }
}