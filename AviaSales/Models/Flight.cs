﻿using System;
using System.Collections.Generic;

namespace AviaSales.Models
{
    public partial class Flight
    {
        public int FlightsId { get; set; }
        public string? FlightTitle { get; set; }
        public DateTime? FlightDate { get; set; }
        public string? FlightCityDeparture { get; set; }
        public string? FlightCityArrival { get; set; }
        public int? FlightCompanyId { get; set; }
        public int? AirplaneId { get; set; }
        public int? NumberOfSeats { get; set; }

        public virtual Airplane? Airplane { get; set; }
        public virtual FlightCompany? FlightCompany { get; set; }
        public virtual AirplaneClassFlight Flights { get; set; } = null!;
    }
}
