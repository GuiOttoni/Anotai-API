using System;
using System.Collections.Generic;
using System.Text;
using Anotai.Api.Core.Configuration;
using Anotai.Api.Core.Entities.Views;
using Anotai.Api.Core.Entities.Models;
using Oracle.ManagedDataAccess.Client;
using System.Net.Http;
using Anotai.Api.Database;

namespace Anotai.Api.Command.Processors
{
    public class PedidoProcessor : Processor
    {
        public PedidoProcessor(string connection, MyOptions _myOptions) : base(connection, _myOptions)
        {
        }

        public async System.Threading.Tasks.Task<object> PostNewPedido( PedidoViewModel pedidoViewModel )
        {
            try
            {
                var resultado = await DbControl.ExecuteProcWithReturnAsync<Pedido>(
                    StoredProcedures.INSERT_PEDIDO, 
                    new OracleCommand());
                return resultado;
            }
            catch (Exception x)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.ExpectationFailed);
            }
        }
    }
}
