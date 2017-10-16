using System;
using System.Collections.Generic;
using System.Text;

namespace Anotai.Api.Core.Entities.Views
{
    /// <summary>
    /// Contrato da API com o FrontEnd, valores que serão recebidos 
    /// </summary>
    public class PagamentoViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public int CodigoConsumidor { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CodigoGarcom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int CodigoMesa { get; set; }
    }
}
