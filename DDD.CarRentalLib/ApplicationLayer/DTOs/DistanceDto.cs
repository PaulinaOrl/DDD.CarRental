using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.CarRentalLib.ApplicationLayer.DTOs
{
    public enum UnitDto
    {
        mil = 0,
        km = 1,

    }
    class DistanceDto
    {
        public double Value { get; set; }
        public UnitDto Unit { get; set; }
    }
}
