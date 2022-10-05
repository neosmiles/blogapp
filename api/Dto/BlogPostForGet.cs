using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dto
{
  public class BlogPostForGet
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public int AuthorId { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.Now;
  }
}