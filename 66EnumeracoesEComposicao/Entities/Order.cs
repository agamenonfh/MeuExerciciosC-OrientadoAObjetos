using System;
using System.Collections.Generic;
using System.Text;
using EnumeracoesEComposicao.Entities.Enums;

namespace EnumeracoesEComposicao.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        override public string ToString()
        {
            return $"Order Id: {Id}, Moment: {Moment}, Status: {Status}";
        }
    }
}
