using FluentValidation;
using MyLibraryApp.Application.Dtos;

public class CreateAuthorDtoValidator : AbstractValidator<CreateAuthorDto>
{
    public CreateAuthorDtoValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MinimumLength(2);
    }
}
