using DDD.Base.DomainModelLayer.Events;
using DDD.Base.DomainModelLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.CarRentalLib.DomainModelLayer.Models
{
    public enum CarStatus
    {
        unreserved=0,
        reserved=1,
        rent=2
    }
    class Car:AggregateRoot
    {
        public Guid CarId { get; protected set; }
        public string RegistrationNumber { get; protected set; }
        public CarStatus Status { get; protected set; }

        public Car(Guid carId, string registrationNumber , IDomainEventPublisher eventPublisher) : base(carId, eventPublisher)
        {
            if (String.IsNullOrEmpty(registrationNumber)) throw new Exception("Car registration number is null or empty");
            RegistrationNumber = registrationNumber;
            Status = CarStatus.unreserved;

           // this.DomainEventPublisher.Publish(new CarCreatedEvent(this.Id,))
        }
    }
}
