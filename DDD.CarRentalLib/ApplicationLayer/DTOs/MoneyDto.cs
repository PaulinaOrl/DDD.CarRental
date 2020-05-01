using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.CarRentalLib.ApplicationLayer.DTOs
{
    class MoneyDto
    {
        public float Value { get; protected set; }
        public string Currency { get; protected set; }
    }
}
