using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.CarRentalLib.ApplicationLayer.DTOs
{
    class DriverDto
    {
        public string LicenceNumber { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }

        public int FreeMinutes { get; protected set; }
    }
}
