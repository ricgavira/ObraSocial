using System.ComponentModel;

namespace ObraSocial.Domain.Enums
{
    public enum Sexo
    {
        [Description("Sexo Feminino")]
        Feminino = 0,
        [Description("Sexo Masculino")]
        Masculino = 1,
        [Description("Outras orientações sexuais")]
        Outro = 2
    }
}
