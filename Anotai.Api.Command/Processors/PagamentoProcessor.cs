using Anotai.Api.Core.Configuration;
using Anotai.Api.Core.Entities.Models;
using Anotai.Api.Core.Entities.Views;
using Anotai.Api.Database;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace Anotai.Api.Command.Processors
{
    public class PagamentoProcessor : Processor
    {
        public PagamentoProcessor(string connection, MyOptions _myOptions) : base(connection, _myOptions)
        {
        }

        public async System.Threading.Tasks.Task<object> PostPagamento(PagamentoViewModel pagamentoViewModel)
        {
            try
            {
                Pagamento pagamento = await GetPagamentoInfo(pagamentoViewModel);

                if (pagamento != null)
                {
                    var resultado = await DbControl.ExecuteProcWithReturnAsync<object>(
                                    StoredProcedures.InsertPagamento,
                                    new OracleCommand());
                    return resultado;
                }
                return "Deu ruim!";
            }
            catch (Exception x)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.ExpectationFailed);
            }
        }

        private async System.Threading.Tasks.Task<Pagamento> GetPagamentoInfo(PagamentoViewModel pagamentoViewModel)
        {
            List<Pagamento> listPagamento = new List<Pagamento>();
            try
            {
                listPagamento = await DbControl.ExecuteProcWithReturnAsync<Pagamento>(
                       StoredProcedures.GetPagamentoInfo,
                       new OracleCommand()
                       );
            }
            catch (Exception ex)
            {

            }
            return listPagamento.FirstOrDefault();
        }
    }
}

