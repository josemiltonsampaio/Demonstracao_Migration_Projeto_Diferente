using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Repositorio;

namespace Demonstracao;
public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var builder = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer(config.GetConnectionString("sqlConexao"),
            b => b.MigrationsAssembly("Demonstracao"));

        return new AppDbContext(builder.Options);
    }
}
