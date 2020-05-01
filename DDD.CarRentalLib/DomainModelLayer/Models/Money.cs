using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.CarRentalLib.DomainModelLayer.Models
{
    class Money
    {
        public float Value { get; protected set; }
        public string Currency { get; protected set; }
    }
}
