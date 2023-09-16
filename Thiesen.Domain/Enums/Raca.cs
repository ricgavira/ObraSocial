using System.ComponentModel;

namespace ObraSocial.Domain.Enums
{
    public enum Raca
    {
        [Description("Branco")]
        Branco = 0,
        [Description("Negro")]
        Negro = 1,
        [Description("Asiático")]
        Asiático = 2,
        [Description("Indígena")]
        Indígena = 3,
        [Description("Pardo")]
        Pardo = 4,
        [Description("Amarelo")]
        Amarelo = 5,
        [Description("Outro")]
        Outro = 6
    }
}
