using CasaPopular.Api.Model;
using CasaPopular.Domain.Interfaces;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using CadastroCasaPopular.Api.ViewModel;
using CasaPopular.Domain.Model;
using CadastroCasaPopular.Domain.Interfaces;

namespace CasaPopular.Domain.Services
{
    public class CasaPopularService : ICasaPopularService
    {
        private readonly ICasaPopularRepository _casaPopularRepository;
        private readonly ICalculaRendaService _calculaRendaService;
        private readonly ICalculaDependenteService _calculaDependenteservice;
        private readonly IMapper _mapper;

        public CasaPopularService(ICasaPopularRepository casaPopularRepository, ICalculaRendaService calculaRendaService, ICalculaDependenteService calculaDependenteservice, IMapper mapper)
        {
            _casaPopularRepository = casaPopularRepository;
            _calculaRendaService = calculaRendaService;
            _calculaDependenteservice = calculaDependenteservice;
            _mapper = mapper;
        }

        public async Task<bool> CadastrarFamilia(FamiliaViewModel dados)
        {
            var pontoRenda = _calculaRendaService.Calcular(dados);

            var pontoDependente = _calculaDependenteservice.Calcular(dados);

            dados.Pontuacao = this.SomarPontuacao(pontoRenda, pontoDependente);

            var dadosFamilia = MontarDadosFamilia(dados);

            var dadosFilho = MontarDadosFilho(dados, dadosFamilia);

            return await _casaPopularRepository.Adicionar(dadosFamilia); 
        }

        public async Task<IEnumerable<Familia>> ConsultarFamilias()           
        {
            return await _casaPopularRepository.Consultar();            
        }

        #region PRIVATE AREA  
        private int SomarPontuacao(int pontoRenda, int pontoDependente)
        {
            return pontoRenda + pontoDependente;
        }

        private Familia MontarDadosFamilia(FamiliaViewModel dados)
        {
            return _mapper.Map<Familia>(dados);
        }

        private List<Filho> MontarDadosFilho(FamiliaViewModel dados, Familia familia)
        {
            var dadosFilhos = _mapper.Map<List<Filho>>(dados.Filhos);

            foreach (var item in dadosFilhos)
            {
                item.FamiliaId = familia.Id;
            }

            return dadosFilhos;
        }
        #endregion
    }
}
