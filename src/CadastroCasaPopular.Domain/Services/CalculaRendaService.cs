using CadastroCasaPopular.Api.ViewModel;
using CadastroCasaPopular.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using static CadastroCasaPopular.Domain.Enum.Enumeradores;

namespace CadastroCasaPopular.Domain.Services
{
    public class CalculaRendaService : ICalculaRendaService
    {
        public int Calcular(FamiliaViewModel dados)
            => dados.RendaFamiliar <= (decimal)Renda.Menor ? (int)Pontuacao.RendaBaixa :
               dados.RendaFamiliar > (decimal)Renda.Menor && dados.RendaFamiliar <= (decimal)Renda.Media ? (int)Pontuacao.RendaMedia : 0;
               
    }
}
