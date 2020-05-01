using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.CarRentalLib.ApplicationLayer.DTOs
{
    class RentalDto
    {
        public Guid RentalId { get; protected set; }
        public DateTime Started { get; protected set; }
        public DateTime Finished { get; protected set; }



        public Guid CarId { get; protected set; }
        public Guid DriverId { get; protected set; }
    }
}
