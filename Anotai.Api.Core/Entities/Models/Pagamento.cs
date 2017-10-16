using System;
using System.Collections.Generic;
using System.Text;

namespace Anotai.Api.Core.Entities.Models
{
    public class Pagamento
    {
        /// <summary>
        /// 
        /// </summary>
        int CodigoCartao { get; set; }

        /// <summary>
        /// 
        /// </summary>
        int Comanda { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string StatusPagamento { get; set; }

        /// <summary>
        /// 
        /// </summary>
        decimal ValorTotal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        int CodigoEC { get; set; }
    }
}
