using DDD.Base.DomainModelLayer.Models;
using System;
using System.Collections.Generic;

namespace DDD.CarRentalLib.DomainModelLayer.Models
{

    class Position:ValueObject
    {
        public double XPosition { get; protected set; }

        public double YPosition { get; protected set; }

        public Unit Unit { get; protected set; }

        public Position(double XPosition, double YPosition,Unit Unit)
        {
            this.XPosition = XPosition;
            this.YPosition = YPosition;
            this.Unit = Unit;
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return XPosition;
            yield return YPosition;
            yield return Unit;
        }
        public Distance CalculateDistance(Position p)
        {
            Distance d = new Distance(0,this.Unit);
           
            if (this.Unit == p.Unit)
            {
                d.Value = Math.Sqrt((this.XPosition - p.XPosition) * (this.XPosition - p.XPosition) + (this.YPosition - p.YPosition) * (this.YPosition - p.YPosition));
                return d;
            }
            else
            {
                throw new Exception("ERROR");
            }

        }
    }
}
