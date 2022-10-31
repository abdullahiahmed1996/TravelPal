using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPal.Enums;

namespace TravelPal.Travel
{
    public class Vacation : Travel
    {
        public Vacation(string destination, Countries country, int numOfTravellers) : base(destination, country, numOfTravellers)
        {
            Destination = destination;
            Country = country;
        }

        //public override string GetInfo()
        //{
        //    return $"Travel to {Country}";
        //}

    }
}
