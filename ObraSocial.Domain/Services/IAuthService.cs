namespace ObraSocial.Domain.Services
{
    public interface IAuthService
    {
        string GenerateJwtToken(string login, string role);
        string ComputedSha256Hash(string password);
    }
}