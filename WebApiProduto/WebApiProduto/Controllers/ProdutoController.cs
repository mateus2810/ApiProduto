using Dapper.Contrib.Extensions;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApiProduto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {

        private readonly IProdutoService _produtoService;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ProdutoController> _logger;

        public ProdutoController(IProdutoService produtoService, ILogger<ProdutoController> logger)
        {
            _produtoService = produtoService;
            _logger = logger;
        }

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        [Route("produto")]
        [HttpGet]
        public ActionResult<IEnumerable<ProdutoDto>> ListarProduto()
        {

            var retorno = _produtoService.ListarProdutoService();

            return Ok(retorno);//ok = injeção tbm
        }

        [Route("criar")]
        [HttpPost]
        public IActionResult CriarProduto([FromBody] ProdutoDto produto)
        {

            var retorno = _produtoService.CriarProdutoService(produto);

            return Ok();
        }

        [Route("editar")]
        [HttpPost]
        public IActionResult EditarProduto([FromBody] ProdutoDto produto)
        {

            var retorno = _produtoService.EditarProdutoService(produto);

            return Ok();
        }

        [Route("excluir")]
        [HttpPost]
        public IActionResult ExcluirProduto(ProdutoDto produto)//alterar depois pelo id
        {

            var retorno = _produtoService.ExcluirProdutoService(produto);

            return Ok();
        }
    }
}
