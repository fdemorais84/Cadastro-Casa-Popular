using CadastroCasaPopular.Api.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroCasaPopular.Domain.Interfaces
{
    public interface ICalculaDependenteService
    {
        int Calcular(FamiliaViewModel dados);
    }
}
