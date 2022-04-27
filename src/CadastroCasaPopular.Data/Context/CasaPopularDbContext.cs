using CasaPopular.Api.Model;
using CasaPopular.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace CadastroCasaPopular.Data.Context
{
    public class CasaPopularDbContext : DbContext
    {
        public DbSet<Familia> Familias { get; set; }
        public DbSet<Filho> Filhos { get; set; }


        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");

    }
}
