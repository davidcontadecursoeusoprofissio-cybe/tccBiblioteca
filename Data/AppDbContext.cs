using Microsoft.EntityFrameworkCore;
using tccBiblioteca.Models;

namespace tccBiblioteca.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<Livro> Livros { get; set; }
}