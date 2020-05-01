using DDD.Base.DomainModelLayer.Events;
using DDD.Base.DomainModelLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.CarRentalLib.DomainModelLayer.Models
{
    class Rental:AggregateRoot
    {
        public Guid RentalId { get; protected set; }
        public DateTime Started { get; protected set; }
        public DateTime Finished { get; protected set; }

        

        public Guid CarId { get; protected set; }
        public Guid DriverId { get; protected set; }
        public Rental(Guid rentalId, DateTime started,DateTime finished, IDomainEventPublisher eventPublisher,Guid carId, Guid driverId) : base(rentalId, eventPublisher)
        {
            
            this.Started = started;
            this.Finished = finished;
            this.CarId = carId;
            this.DriverId = driverId;
            
             

            // this.DomainEventPublisher.Publish(new CarCreatedEvent(this.Id,))
        }
    }
}
