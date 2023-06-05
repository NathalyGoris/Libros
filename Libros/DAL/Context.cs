using Microsoft.EntityFrameWorkCore;
using Libros.Models;

public class Context : DbContext
{
    public Context(DbContextOptions<Libros> Options)
        :base(Options){}

    public DbSet<Libros> Libros {get; set;}
  
  
}