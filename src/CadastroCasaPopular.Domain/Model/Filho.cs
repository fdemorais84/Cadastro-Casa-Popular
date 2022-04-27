using CadastroCasaPopular.Domain.Model;
using System;

namespace CasaPopular.Domain.Model
{
    public class Filho : Entity
    {        
        public string Nome { get; set; }
        public int Idade { get; set; }        
        public Guid FamiliaId { get; set; }

    }
}
