namespace CadastroCasaPopular.Domain.Enum
{
    public static class Enumeradores
    {
        public enum Renda
        {
            Menor = 900,
            Media = 1500
        }

        public enum Dependente
        {
            FaixaMaior = 3,
            FaixaMenor = 2
        }

        public enum Idade
        {
            Adulto = 18
        }

        public enum Pontuacao
        {
            RendaMedia = 3,
            RendaBaixa = 5,
            DependenteAlto = 3,
            DependenteBaixo = 2
        }
    }
}
