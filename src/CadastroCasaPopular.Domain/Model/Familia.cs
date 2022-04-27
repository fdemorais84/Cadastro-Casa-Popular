using CadastroCasaPopular.Domain.Model;
using CasaPopular.Domain.Model;
using System.Collections.Generic;

namespace CasaPopular.Api.Model
{
    public class Familia : Entity
    {  
        public string Sobrenome { get; set; }
        public string Pai { get; set; } 
        public string Mae { get; set; }
        public decimal RendaFamiliar { get; set; }       
        public int Pontuacao { get; set; }

        public List<Filho> Filhos { get; set; }
    }
}
