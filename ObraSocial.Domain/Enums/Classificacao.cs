using System.ComponentModel;

namespace ObraSocial.Domain
{
    public enum Classificacao
    {
        [Description("Trabalhador")]
        Trabalhador = 0,
        [Description("Assistido")]
        Assistido = 1,
        [Description("Direção")]
        Direcao = 2,
        [Description("Funcionário")]
        Funcionario = 3
    }
}