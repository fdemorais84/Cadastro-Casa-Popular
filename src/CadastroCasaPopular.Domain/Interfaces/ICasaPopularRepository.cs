using CasaPopular.Api.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CasaPopular.Domain.Interfaces
{
    public interface ICasaPopularRepository
    {
        Task<IEnumerable<Familia>> Consultar();
        Task<bool> Adicionar(Familia dados);
        Task<int> SaveChanges();
        void Dispose();
    }
}
