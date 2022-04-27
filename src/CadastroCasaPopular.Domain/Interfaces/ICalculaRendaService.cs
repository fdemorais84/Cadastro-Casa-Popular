using CadastroCasaPopular.Api.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroCasaPopular.Domain.Interfaces
{
    public interface ICalculaRendaService
    {
        int Calcular(FamiliaViewModel dados);
    }
}
