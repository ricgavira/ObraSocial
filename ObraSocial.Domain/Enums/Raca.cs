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
        Asiatico = 2,
        [Description("Indígena")]
        Indigena = 3,
        [Description("Pardo")]
        Pardo = 4,
        [Description("Amarelo")]
        Amarelo = 5,
        [Description("Outro")]
        Outro = 6
    }
}
