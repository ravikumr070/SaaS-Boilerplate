namespace Application.Identity.Tokens;

public interface ITokenService : ITransientService
{
    Task<TokenResponse> GetTokenAsync(TokenRequest request, string ipAddress, string browserInfo, CancellationToken cancellationToken);

    Task<TokenResponse> RefreshTokenAsync(RefreshTokenRequest request, string ipAddress, string browserInfo);
}