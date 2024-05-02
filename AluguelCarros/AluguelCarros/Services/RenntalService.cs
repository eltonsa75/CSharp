using System;
using AluguelCarros.Entities;

namespace AluguelCarros.Services
{
    internal class RenntalService
    {

        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        public RenntalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {

        }
    }
}
