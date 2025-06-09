using Microsoft.AspNetCore.Mvc;
using MyLibraryApp.Application.Dtos;
using MyLibraryApp.Domain.Entities;
using MyLibraryApp.Infrastructure.Persistence;
using AutoMapper;

[ApiController]
[Route("api/[controller]")]
public class AuthorsController(AppDbContext context, IMapper mapper) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateAuthorDto dto)
    {
        var author = mapper.Map<Author>(dto);
        context.Authors.Add(author);
        await context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetById), new { id = author.Id }, author);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var author = await context.Authors.FindAsync(id);
        return author == null ? NotFound() : Ok(author);
    }
}
