using HttpClientFactory.Models;
using HttpClientFactory.Services;
using Microsoft.AspNetCore.Mvc;

namespace HttpClientFactory.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAutenticacao _autenticacaoService;

        public AccountController(IAutenticacao autenticacaoService)
        {
            _autenticacaoService = autenticacaoService;
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(UsuarioViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Login inválido");
                return View(model);
            }

            var result = await _autenticacaoService.AutenticaUsuario(model);

            if (result is null)
            {
                ModelState.AddModelError(string.Empty, "Login inválido");
                return View(model);
            }

            //Armazenando o token no cookie
            Response.Cookies.Append("X-Access-Token", result.Token, new CookieOptions()
            {
                Secure = true,
                HttpOnly = true,
                SameSite = SameSiteMode.Strict
            });
            return Redirect("/");
        }
    }
}