using Microsoft.EntityFrameworkCore;
using revisao.c_.prova.Entities;

namespace revisao.c_.prova.Contexto
{
    public sealed class ContextoBancoDados : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public ContextoBancoDados(DbContextOptions<ContextoBancoDados> options) : base(options)
        {
            if (Database.GetPendingMigrations().Any())
                Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //precisa saber implementar
            modelBuilder.ApplyConfiguration(new mappings.ClienteMapping());

        }
    }
}
