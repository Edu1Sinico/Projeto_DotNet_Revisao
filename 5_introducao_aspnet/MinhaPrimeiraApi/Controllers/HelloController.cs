using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; // Importa os recursos necessários para criar Controllers
using Microsoft.Extensions.Logging;

namespace MinhaPrimeiraApi.Controllers // Define o namespace da classe
{
    [ApiController] // Informa ao ASP.NET Core que essa classe é um Controller de API
    [Route("api/[controller]")] // Define a rota base (endpoint do nosso projeto.)
    // Cria um Controller de API -> ControllerBase é usado quando não precisamos trabalhar com views/telas, apenas respostas HTTP.
    public class HelloController : Controller // o nome do endpoint ficaria como (/api/hello), ele desconsidera o "Controller" e deixa tudo em lowerCase.
    {
        [HttpGet] // Define uma requisição HTTP do método GET
        public IActionResult Get() // Método que será executado quando alguém acessar (GET /api/hello)
        {
            return Ok("Olá, mundo! Minha primeira API ASP.NET Core."); // Retorna status "200 OK" com uma mensagem.
        }

        // Receber um nome pela rota
        [HttpGet("{nome}")]
        public IActionResult GetComNome(string nome) // Recebe o nome como parâmetro
        {
            return Ok($"Olá {nome}! Seja-bem vindo à minha API.");
        }
    }
}