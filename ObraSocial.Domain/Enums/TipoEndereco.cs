using System.ComponentModel;

namespace ObraSocial.Domain.Enums
{
    public enum TipoEndereco
    {
        [Description("Endereço Comercial")]
        Comercial = 0,
        [Description("Endereço Residencial")]
        Residencial = 1
    }
}
