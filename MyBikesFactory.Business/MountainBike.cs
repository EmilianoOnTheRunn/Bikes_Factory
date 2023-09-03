using MyBikesFactory.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactory.Business
{
    [Serializable]
    public class MountainBike : Bike
    {
        private ESuspension _suspensionType;

        public ESuspension SuspensionType { get => _suspensionType; set => _suspensionType = value; }

        public override string ToString()
        {
            return "Bike Type: Mountain, " + base.ToString() + ", Suspension Type: " + _suspensionType.ToString();
        }

        public MountainBike() : base()
        {
            _suspensionType = ESuspension.Undefined;
        }

        public MountainBike(ESuspension initialBrakeType) : base()
        {
            _suspensionType = initialBrakeType;
        }

        public override bool IsValid()
        {
            bool isValidFromBase = base.IsValid();

            if (!isValidFromBase)
                return false;
            else if (_suspensionType == ESuspension.Undefined)
            {
                GotInvalidChildNotification("Please select a suspension type");
                return false;
            }
            return true;
        }
    }
}
