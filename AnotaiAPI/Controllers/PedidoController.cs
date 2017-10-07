using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Anotai.Api.Core.Entities.Models;
using Anotai.Api.Command.Processors;
using Anotai.Api.Core.Configuration;
using Anotai.Api.Core.Entities.Views;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnotaiAPI.Controllers
{
    [Produces("application/json")]
    public class PedidoController : Controller
    {
        #region > VARIAVEIS <
        /// <summary>
        /// Opções do appsettings.json
        /// </summary>
        private readonly MyOptions _options;

        /// <summary>
        /// Processor referente a o controller
        /// </summary>
        private PedidoProcessor processor;
        #endregion


        /// <summary>
        /// Construtor padrão do controller
        /// </summary>
        /// <param name="optionsAccessor"></param>
        public PedidoController(Microsoft.Extensions.Options.IOptions<MyOptions> optionsAccessor)
        {
            _options = optionsAccessor.Value;
            processor = new PedidoProcessor(_options.ConnectionString, _options);
        }


        /// <summary>
        /// Seleciona todos os pedidos referente a uma comanda
        /// </summary>
        /// <param name="comanda"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/get/pedidos")]
        public async Task<IActionResult> Get([FromBody]ComandaViewModel comandaViewModel)
        {
            return Json("");
        }

        /// <summary>
        /// Insere um novo pedido no banco
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/new/pedido")]
        public async Task<IActionResult> Post([FromBody]PedidoViewModel pedidoViewModel)
        {
            return Json(await processor.PostNewPedido(pedidoViewModel));
        } 
    }
}
