using Microsoft.EntityFrameworkCore;
using Modelos;

namespace Repositorio;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
    {

    }
    public DbSet<Escola> Escolas { get; set; }
}
