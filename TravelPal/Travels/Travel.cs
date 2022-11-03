using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using TravelPal.Enums;

namespace TravelPal.Travels;

public class Travel
{
    // Properties
    public Countries Country { get; set; }
    public int numOfTravellers { get; set; }
    public string Destination { get; set; }

    //Costuctor
    public Travel(string destination, Countries country, int numOfTravellers)
    {
        this.Destination = destination;
        this.Country = country;
        this.numOfTravellers = numOfTravellers;
    }

    // A virtual method that returns the country
    public virtual string GetInfo()
    {
        return $"{Country}";
    }

    // A virtual method that returns the travel type
    public virtual string GetTravelType()
   {
        return "TravelType";
   }

    // A virtual method that returns the travel info
    public virtual string GetTravelInfo()
    {
        return "TravelInfo";
    }
}
