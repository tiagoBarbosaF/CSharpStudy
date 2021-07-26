using System;
using InterfacePart01.Entities;

namespace InterfacePart01.Services
{
    class RentalService
    {
        public double pricePerHour { get; private set; }
        public double pricePerDay { get; private set; }

        private ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            this.pricePerHour = pricePerHour;
            this.pricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.finish.Subtract(carRental.start);

            double basicPayment = 0;

            if (duration.TotalHours <= 12)
            {
                basicPayment = pricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = pricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double Tax = _taxService.Tax(basicPayment);

            carRental.invoice = new Invoice(basicPayment, Tax);
        }
    }
}
