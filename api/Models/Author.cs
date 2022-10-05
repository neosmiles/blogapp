using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // I
        public ICollection<BlogPost> BlogPosts { get; set; }
    }
}