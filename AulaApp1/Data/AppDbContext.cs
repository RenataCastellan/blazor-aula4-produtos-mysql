using AulaApp1.Components.Models;
using Microsoft.EntityFrameworkCore;

namespace AulaApp1.Data
{
    // O DbContext é a "sessão" com o banco: ele abre a conexão, acompanha
    // as mudanças feitas nos objetos e grava tudo quando chamamos SaveChangesAsync().
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Cada DbSet representa uma tabela. Este vira a tabela "Produtos".
        public DbSet<Produto> Produtos => Set<Produto>();
    }
}
