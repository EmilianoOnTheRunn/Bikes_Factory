using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using MyBikesFactory.Business.Interfaces;


namespace MyBikesFactory.Business
{
    public static class Validator
    {

        public static bool CheckValidity(IValidatable objectToCheck)
        {
            bool result = objectToCheck.IsValid();
            if (result == false)
                System.Diagnostics.Debug.WriteLine("The object " +
                                                objectToCheck + " has a problem: " +
                                                objectToCheck.InvalidMessage);
            return result;
        }

        public static bool ValidateId(string inputToCheck)
        {
            //return int.TryParse(inputToCheck, out _);

            return Regex.IsMatch(inputToCheck, "^[0-9]+$");
        }

        public static bool ValidateUniqueId(string inputToCheck, List<Bike> listOfSBikes)
        {
            int id = Convert.ToInt32(inputToCheck);
            foreach (var bike in listOfSBikes)
            {
                if (bike.Id == id)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool ValidateModel(string inputToCheck)
        {
            return Regex.IsMatch(inputToCheck, @"^\w{5}$");
        }

        public static bool ValidateManufacturingYear(string inputToCheck)
        {
            return Regex.IsMatch(inputToCheck, @"^\w{4}$");
        }

    }
}
