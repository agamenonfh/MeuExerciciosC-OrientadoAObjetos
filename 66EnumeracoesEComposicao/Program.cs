using System;
using System.Globalization;
using EnumeracoesEComposicao.Entities;
using EnumeracoesEComposicao.Entities.Enums;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString(); //Concertendo o enum para string
            
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); //Convertendo string para enum")

            Console.WriteLine(txt);
            Console.WriteLine(os);

        }
    }
}