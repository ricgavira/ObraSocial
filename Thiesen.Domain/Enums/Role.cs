using System.ComponentModel;

namespace ObraSocial.Domain.Enums
{
    public enum Role
    {
        [Description("Administrador")]
        Administrator,
        [Description("Usuario comum")]
        User
    }
}
