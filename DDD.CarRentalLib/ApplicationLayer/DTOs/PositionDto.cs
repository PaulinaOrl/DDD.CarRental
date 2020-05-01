using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.CarRentalLib.ApplicationLayer.DTOs
{
    class PositionDto
    {
        public double XPosition { get; protected set; }

        public double YPosition { get; protected set; }

        public UnitDto Unit { get; protected set; }
    }
}
