using HttpClientFactory.Models;

namespace HttpClientFactory.Services
{
    public interface IAutenticacao
    {
        Task<TokenViewModel> AutenticaUsuario(UsuarioViewModel usuarioVM);
    }
}