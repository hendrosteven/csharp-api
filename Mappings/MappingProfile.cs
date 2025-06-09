using AutoMapper;
using MyLibraryApp.Application.Dtos;
using MyLibraryApp.Domain.Entities;

namespace MyLibraryApp.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateAuthorDto, Author>();
        CreateMap<CreateBookDto, Book>();

        // Entity -> Read DTOs
        CreateMap<Author, AuthorDto>()
            .ForMember(dest => dest.BookTitles, opt => opt.MapFrom(src => src.Books.Select(b => b.Title)));

        CreateMap<Book, BookDto>()
            .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author.Name));
    }
}
