using System;
using System.Collections.Generic;
using System.Text;

namespace Anotai.Api.Core.Entities.Models
{
    public class Pedido
    {
        /// <summary>
        /// 
        /// </summary>
        public int IdPedido { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Garcom Garcom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Mesa IdMesas { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public Estabelecimento Estabelecimento { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Cartao Cartao { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Consumidor Consumidor { get; set; }
    }
}
