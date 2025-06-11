namespace MyLibraryApp.Application.Dtos;

public class CreateBookDto
{
    public string Title { get; set; } = default!;
    public int AuthorId { get; set; }


    // public void setId(int id)
    // {
    //     if()
    //     AuthorId = id;
    // }
}
