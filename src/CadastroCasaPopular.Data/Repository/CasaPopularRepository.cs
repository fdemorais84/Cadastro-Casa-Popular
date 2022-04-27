using CadastroCasaPopular.Data.Context;
using CasaPopular.Api.Model;
using CasaPopular.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaPopular.Data.Repository
{
    public class CasaPopularRepository : ICasaPopularRepository
    {
        protected readonly CasaPopularDbContext Db;
        protected readonly DbSet<Familia> DbSet;

        public CasaPopularRepository(CasaPopularDbContext db)
        {
            Db = db;
            DbSet = db.Set<Familia>();
        }

        public async Task<IEnumerable<Familia>> Consultar()
        {
            return await Db.Familias.AsNoTracking().Include(f => f.Filhos)
                .OrderByDescending(f => f.Pontuacao).ToListAsync();
        }

        public async Task<bool> Adicionar(Familia dados)
        {
            DbSet.Add(dados);        
            await SaveChanges();
            return true;
        }        

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
