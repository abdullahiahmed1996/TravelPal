using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPal.Enums;

namespace TravelPal.Travel
{
    public class Travel
    {
        public string Destination { get; set; }
        public Countries Country { get; set; }
        public int numOfTravellers { get; set; }

        //public int TravelDays { get; set; }

        public Travel(string destination, Countries country, int numOfTravellers)
        {
            Destination = destination;
            Country = country;
            numOfTravellers = numOfTravellers;
        }

       
    }
}
