using DDD.Base.DomainModelLayer.Models;
using DDD.Base.DomainModelLayer.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.CarRentalLib.DomainModelLayer.Models
{
    public class Driver : AggregateRoot
    {
        
        public string LicenceNumber { get; protected set; }
        public string FirstName{ get; protected set; }
        public string LastName { get; protected set; }

        public int FreeMinutes { get; protected set; }

        public Driver(Guid DriverId, string LicenceNumber, string FirstName, string LastName, IDomainEventPublisher eventPublisher):base(DriverId,eventPublisher) { }

    }
}
