using Microsoft.EntityFrameworkCore;
using Senai2025Api.Entidades;

namespace Senai2025Api.Contexts
{
    public class SenaiContext : DbContext
    {

        public DbSet<Escola> Escola { get; set; }

        public DbSet<Endereco> Endereco { get; set; }

        public DbSet<Professor> Professor { get; set; }

        public DbSet<Classe> Classe { get; set; }

        public DbSet<Aluno> Aluno { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Server=192.168.50.45;Port=5432;Database=Trainee2025;Userid=postgres;Password=pezqE7G7;Pooling=true;MinPoolSize=1;MaxPoolSize=10;MaxPoolSize=10;Timeout=15;CommandTimeout=30;Connection Idle Lifetime=30;");
            }
        }

    }
}
