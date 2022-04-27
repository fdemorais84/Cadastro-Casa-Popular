using CadastroCasaPopular.Api.ViewModel;
using CadastroCasaPopular.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using static CadastroCasaPopular.Domain.Enum.Enumeradores;

namespace CadastroCasaPopular.Domain.Services
{
    public class CalculaDependenteService : ICalculaDependenteService
    {
        public int Calcular(FamiliaViewModel dados)
        {
            var quantidade = dados.Filhos == null ? 0 : this.VerificarQuantidadeFilhos(dados);
            var pontos = quantidade.Equals(0) ? 0 :
                         quantidade >= (int)Dependente.FaixaMaior ? (int)Pontuacao.DependenteAlto :
                         (int)Pontuacao.DependenteBaixo;
            return pontos;
        }



        private int VerificarQuantidadeFilhos(FamiliaViewModel dados)
        {
            try
            {
                var quantidade = 0;
                foreach (var filho in dados.Filhos)
                {
                    if (filho.Idade <= (int)Idade.Adulto) quantidade++;
                }
                return quantidade;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
