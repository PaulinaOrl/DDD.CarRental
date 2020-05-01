using DDD.Base.DomainModelLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.CarRentalLib.DomainModelLayer.Models
{
    public enum Unit
    {
        mil = 0,
        km= 1,
        
    }
    class Distance:ValueObject
    {

        public double Value { get; set; }
        public Unit Unit { get;  protected set; }

        public Distance(float value, Unit unit)
        {
            this.Value = value;
            this.Unit = unit;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
            yield return Unit;
        }

        public int Compare(Distance d)
        {
            if (d.Unit == this.Unit)
            {
                return this.Value.CompareTo(d.Value);
            }
            else { return 0; }
        }
        public double Add(Distance d)
        {
            if (d.Unit==this.Unit)
            {
                this.Value += d.Value;
            }
            else
            {
                this.Value = this.Value;
            }
            return this.Value;
        }
        public double Substract(Distance d)
        {
            if (d.Unit == this.Unit)
            {
                this.Value -= d.Value;
            }
            else
            {
                this.Value = this.Value;
            }
            return this.Value;
        }
        public void Unittokm() 
        {
            this.Value = this.Value * 1.609344;
            this.Unit = Unit.km;
        }
        public void UnittoMiles()
        {
            this.Value = this.Value * 0.62137;
            this.Unit = Unit.mil;
        }

    }
}
