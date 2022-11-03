using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPal.Enums;

namespace TravelPal.Travels;

// Trip class should inherit form Travel
public class Trip : Travel
{
    // Properties
    public TripTypes Type { get; set; }

    public Trip(TripTypes types, string destination, Countries country, int numOfTravellers) : base(destination,country,numOfTravellers)
    {
        this.Type = types;
    }

    public override string GetInfo()
    {
        return $"{Country}";
    }

    public override string GetTravelType()
    {
        return "Trip";
    }

    public override string GetTravelInfo()
    {
        return $"{Type}";
    }

}
