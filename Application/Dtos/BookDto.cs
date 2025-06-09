namespace MyLibraryApp.Application.Dtos;

public class BookDto
{
    public int Id { get; set; }
    public string Title { get; set; } = default!;
    public int AuthorId { get; set; }
    public string AuthorName { get; set; } = default!;
}
