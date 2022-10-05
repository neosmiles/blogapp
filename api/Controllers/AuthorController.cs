using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dto;
using api.Repo;
using api.Repo.Interface;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class AuthorController : ControllerBase
  {
    private readonly IAuthorRepository authorRepository;

    public AuthorController(IAuthorRepository authorRepository)
    {
      this.authorRepository = authorRepository;
    }

    [HttpPost]
    public async
            Task<IActionResult> AddAuthor([FromBody] AuthorForCreation field)
    {
      var dataFromRepo = await authorRepository.AddAuthor(field);
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
    public async Task<IActionResult> getAuthors()
    {
      var dataFromRepo = await authorRepository.GetAuthors();
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
        data = dataFromRepo
      });

    }


    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> getAuthorById(int id)
    {
      var dataFromRepo = await authorRepository.GetAuthorWithId(id);
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
        Data = dataFromRepo
      });
    }


    [HttpPost("Update")]
    public async Task<IActionResult> updateAuthor([FromBody] AuthorForUpdate model)
    {
      var dataFromRepo = await authorRepository.UpdateAuthor(model);
      if (dataFromRepo == null)
      {
        return BadRequest(new
        {
          Message = "Error",
          StatusCode = 401,
          IsSuccesful = false
        });
      }

      return Ok(new
      {
        Message = "Success",
        StatusCode = 200,
        getAuthorById = model.Id,
        Data = dataFromRepo
      });
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> deleteAuthor(int id)
    {
      var dataFromRepo = await authorRepository.DeleteAuthor(id);
      if (!ModelState.IsValid)
        return BadRequest(new
        {
          Message = "Error",
          StatusCode = 401,
          IsSuccessful = false
        });

      return Ok(new
      {
        Message = "Author deleted",
        StatusCode = 200,
        IsSuccessful = true,
        AuthorId = id,
        data = dataFromRepo
      });
    }
  }
}