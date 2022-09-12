using Backend_Lista_Tarefa.Comandos.Login;
using Backend_Lista_Tarefa.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Backend_Lista_Tarefa.Controllers
{
    [ApiController]
    [Route("login")]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpPost]
        public object Login([FromBody] ComandoManipuladorAutenticar comando)
        {
            var senha = _configuration["Usuario:Senha"];
            var login = _configuration["Usuario:Login"];
            var role = _configuration["Usuario:Role"];
            if (comando.Login == login && comando.Senha == senha)
            {
                var token = TokenService.GenerateToken(comando.Login, role);
                var retorno = new
                {
                    statusCode = 200,
                    mensagem = "Usúario autenticado com sucesso.",
                    token = token
                };
                return retorno;
            }
            else
            {
                var retorno = new
                {
                    statusCode = 401,
                    mensagem = "Usúario ou senha inválido."
                };
                return retorno;
            }
        }
    }
}
