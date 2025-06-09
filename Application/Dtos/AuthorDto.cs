namespace MyLibraryApp.Application.Dtos;

public class AuthorDto
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public List<string> BookTitles { get; set; } = new();
}
