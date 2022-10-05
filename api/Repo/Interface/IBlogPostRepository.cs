using System.Collections.Generic;
using System.Threading.Tasks;
using api.Dto;
using api.Models;

namespace api.Repo.Interface
{
    public interface IBlogPostRepository
    {
         void add<T>(T entity) where T : class;
         void Delete<T>(T entity) where T : class;
         Task<bool> SaveAll();

      Task<BlogPost> AddBlogPost(BlogPostForCreation field);
      Task<IEnumerable<BlogPost>> GetBlogPosts();
      Task<IEnumerable<object>> GetBlogPostWithId(int Id);
      Task<IEnumerable<object>> GetBlogPostWithTitle(string title);
      Task<BlogPost> UpdateBlogPost(BlogPostForUpdate model);
      Task <bool> DeletePost(int id);

    }
}