using Microsoft.AspNetCore.Mvc;
using MyLibraryApp.Application.Dtos;
using MyLibraryApp.Domain.Entities;
using MyLibraryApp.Infrastructure.Persistence;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class BooksController(AppDbContext context, IMapper mapper) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateBookDto dto)
    {
        var book = mapper.Map<Book>(dto);
        context.Books.Add(book);
        await context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetById), new { id = book.Id }, book);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var book = await context.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
        if (book == null)
        {
            return NotFound();
        }
        var bookDto = mapper.Map<BookDto>(book);
        return Ok(bookDto);
    }
}
