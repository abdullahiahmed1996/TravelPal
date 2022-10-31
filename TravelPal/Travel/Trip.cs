using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPal.Enums;

namespace TravelPal.Travel;

public class Trip
{
    public TripTypes Type { get; set; }

    //public Trip(string destination, Countries country, int numOfTravels,TripTypes tripTypes) : base(destination,country,numOfTravels)
    //{
    //    Type = tripTypes;
    //}

    //public override string GetInfo()
    //{
    //    return base.GetInfo();
    //}
}
