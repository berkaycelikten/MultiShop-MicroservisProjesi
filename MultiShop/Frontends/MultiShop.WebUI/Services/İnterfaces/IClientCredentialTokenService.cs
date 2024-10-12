namespace MultiShop.WebUI.Services.İnterfaces
{
    public interface IClientCredentialTokenService
    {
        Task<string> GetToken();
    }
}
