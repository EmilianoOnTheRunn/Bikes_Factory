using MyBikesFactory.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactory.Business
{
    public class RoadBike : Bike
    {
        private ETireType _tireType;

        public ETireType TireType { get => _tireType; set => _tireType = value; }

        public override string ToString()
        {
            return "Bike Type: Road, " + base.ToString() + ", Tire Type: " + _tireType.ToString();
        }

        public RoadBike() : base()
        {
            _tireType = ETireType.Undefined;
        }
        public RoadBike(ETireType initialShapeType) : base()
        {
            _tireType = initialShapeType;
        }
        public override bool IsValid()
        {
            bool isValidFromBase = base.IsValid();

            if (!isValidFromBase)
            {
                return false;
            }
            else if (_tireType == ETireType.Undefined)
            {
                GotInvalidChildNotification("Please select a brake type");
                return false;
            }
            return true;
        }
    }
}
