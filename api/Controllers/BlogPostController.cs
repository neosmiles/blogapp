using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dto;
using api.Repo.Interface;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BlogPostController : ControllerBase
  {
    private readonly
    IBlogPostRepository
    blogPostRepository;
    private readonly IMapper mapper;

    public BlogPostController(IBlogPostRepository blogPostRepository, IMapper mapper)
    {
      this.blogPostRepository = blogPostRepository;
      this.mapper = mapper;
    }

    [HttpPost]
    public async
    Task<IActionResult> AddBlogPost([FromBody] BlogPostForCreation field)
    {
      var dataFromRepo = await blogPostRepository.AddBlogPost(field);
      if (dataFromRepo == null)
      {
        return BadRequest
        (new
        {
          message = "Error",
          StatusCode = 401,
          isSuccessful = false
        });
      }

      return Ok(new
      {
        Message = "Success",
        StatusCode = 201,
        IsSuccessful = true,
        Data = dataFromRepo
      });
    }

    [HttpGet]
    public async Task<ActionResult<BlogPostForGet>> getBlogPost()
    {
      var dataFromRepo = await blogPostRepository.GetBlogPosts();
      if (dataFromRepo == null)
      {
        return BadRequest
        (new
        {
          Message = "Error",
          StatusCode = 401,
          IsSuccessful = false
        });
      }

      return Ok(new
      {
        Message = "Success",
        StatusCode = 201,
        IsSuccessful = true,
        Data = mapper.Map<ICollection<BlogPostForGet>>(dataFromRepo)
      });
    }

    [HttpGet]
    [Route("{id:int}")]
    public async Task<IActionResult> getBlogPostWithId(int id)
    {
      var dataFromRepo = await blogPostRepository.GetBlogPostWithId(id);
      if (dataFromRepo == null)
      {
        return BadRequest(new
        {
          Message = "Error",
          StatusCode = 401,
          IsSuccessful = false
        });
      }

      return Ok(new
      {
        Message = "Success",
        StatusCode = 200,
        IsSuccessful = true,
        AuthorId = id,
        data = dataFromRepo
      });
    }

    [HttpGet]
    [Route("title")]
    public async Task<IActionResult> getBlogPostWithTitle(String title)
    {
      var dataFromRepo = await blogPostRepository.GetBlogPostWithTitle(title);
      if (dataFromRepo == null)
      {
        return BadRequest(new
        {
          Message = "Error",
          StatusCode = 401,
          IsSuccessful = false
        });
      }

      return Ok(new
      {
        Message = "Success",
        StatusCode = 201,
        IsSuccessful = true,
        data = mapper.Map<ICollection<BlogPostForGet>>(dataFromRepo)
      });
    }


    [HttpPost("Update")]
    public async Task<IActionResult> UpdateBlogPost(BlogPostForUpdate model)
    {
      var dataFromRepo = await blogPostRepository.UpdateBlogPost(model);
      if (dataFromRepo == null)
      {
        return BadRequest(new
        {
          Message = "Error",
          StatusCode = 401,
          IsSuccessful = false
        });
      }

      return Ok(new
      {
        Message = "Success",
        StatusCode = 201,
        IsSuccessful = true,
        data = dataFromRepo
      });
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> deletePost(int id)
    {
      var dataFromRepo = await blogPostRepository.DeletePost(id);
      if (!ModelState.IsValid)
        return BadRequest(new
        {
          Message = "Error",
          StatusCode = 401,
          IsSuccessful = false
        });

      return Ok(new
      {
        Message = "Post deleted",
        StatusCode = 201,
        IsSuccessful = true,
        PostId = id,
        dataFromRepo
      });
    }

  }
}