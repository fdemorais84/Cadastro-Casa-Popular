using CasaPopular.Api.Model;
using CasaPopular.Domain.Model;
using AutoMapper;
using CadastroCasaPopular.Api.ViewModel;

namespace CasaPopular.Api.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<FamiliaViewModel, Familia>();
            CreateMap<FilhoViewModel, Filho>();
        }
    }
}
