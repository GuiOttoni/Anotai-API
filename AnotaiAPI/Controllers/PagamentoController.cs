using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Anotai.Api.Core.Configuration;
using Anotai.Api.Command.Processors;
using Anotai.Api.Core.Entities.Views;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnotaiAPI.Controllers
{
    public class PagamentoController : Controller
    {
        #region > VARIAVEIS <
        /// <summary>
        /// Opções do appsettings.json
        /// </summary>
        private readonly MyOptions _options;

        /// <summary>
        /// Processor referente a o controller
        /// </summary>
        private PagamentoProcessor processor;
        #endregion


        /// <summary>
        /// Construtor padrão do controller
        /// </summary>
        /// <param name="optionsAccessor"></param>
        public PagamentoController(Microsoft.Extensions.Options.IOptions<MyOptions> optionsAccessor)
        {
            _options = optionsAccessor.Value;
            processor = new PagamentoProcessor(_options.ConnectionString, _options);
        }


        [Route("api/pagar")]
        [HttpPost]
        public async Task<IActionResult> PostPagamentoAsync([FromBody] PagamentoViewModel pagamento)
        {
            return Json(await processor.PostPagamento(pagamento));
        }

    }
}
