using Microsoft.EntityFrameworkCore;
using MyLibraryApp.Domain.Entities;

namespace MyLibraryApp.Infrastructure.Persistence;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Author> Authors => Set<Author>();
    public DbSet<Book> Books => Set<Book>();
}
