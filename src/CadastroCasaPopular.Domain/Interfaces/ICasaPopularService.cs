using CadastroCasaPopular.Api.ViewModel;
using CasaPopular.Api.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CasaPopular.Domain.Interfaces
{
    public interface ICasaPopularService
    {
        Task<bool> CadastrarFamilia(FamiliaViewModel dados);
        Task<IEnumerable<Familia>> ConsultarFamilias();
    }
}
