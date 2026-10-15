using System;
using Course.Entities;

namespace Course.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        private ITaxService _taxService; // essa alteração só é possível com a implementação de uma interface.
                                         // E também é conhecida como inversão de controle por meio de injeção de depedência;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }
        //Isso aqui foi feito de forma inadequada para que possamos discutir qual é a melhor maneira de executar esse tipo de trabalho.

        // private BrazilTaxService _brazilTaxService = new BrazilTaxService(); 
        
        // assim é necessário ter dependência de um serviço definido
        // dessa forma sempre que tiver de fazer alguma alteração no serviço
        // eu terei a necessidade de criar um novo serviço e abrir essa classe
        // RetalService par afazer alterações.
        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
