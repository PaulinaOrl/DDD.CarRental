using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.CarRentalLib.ApplicationLayer.DTOs
{
    public enum CarStatusDto
    {
        unreserved = 0,
        reserved = 1,
        rent = 2
    }
    class CarDto
    {
        public Guid CarId { get; set; }
        public string RegistrationNumber { get; set; }
        public CarStatusDto Status { get; set; }

      
    }
}
