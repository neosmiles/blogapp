using System;

namespace api.Dto
{
    public class BlogPostForUpdate
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;
    }
}