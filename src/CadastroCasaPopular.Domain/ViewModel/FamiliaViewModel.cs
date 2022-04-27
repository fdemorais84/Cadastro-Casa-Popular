using System.Collections.Generic;

namespace CadastroCasaPopular.Api.ViewModel
{
    public class FamiliaViewModel
    {
        public string Sobrenome { get; set; }
        public string Pai { get; set; }
        public string Mae { get; set; }
        public decimal RendaFamiliar { get; set; }
        public int Pontuacao { get; set; }
        public List<FilhoViewModel> Filhos { get; set; }
    }

    public class FilhoViewModel
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
