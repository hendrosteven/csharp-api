using FluentValidation;
using MyLibraryApp.Application.Dtos;

public class CreateBookDtoValidator : AbstractValidator<CreateBookDto>
{
    public CreateBookDtoValidator()
    {
        RuleFor(x => x.Title).NotEmpty();
        RuleFor(x => x.AuthorId).GreaterThan(0);
    }
}
