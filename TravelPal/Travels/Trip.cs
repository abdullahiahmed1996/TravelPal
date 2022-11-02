using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPal.Enums;

namespace TravelPal.Travels;

public class Trip : Travel
{
    //private string[] tripType;
    //private int numOfTravellers;
    public TripTypes Type { get; set; }

    public Trip(TripTypes types, string destination, Countries country, int numOfTravellers) : base(destination,country,numOfTravellers)
    {
        this.Type = types;
    }

    public override string GetInfo()
    {
        return $"Trip to {base.Country}";
    }
}
