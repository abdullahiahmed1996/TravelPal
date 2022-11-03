using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPal.Enums;

namespace TravelPal.Travels;

// Vacation class should inherit form Travel
public class Vacation : Travel
{
    public bool AllInclusive { get; set; }
    public Vacation(string destination, Countries country, int numOfTravellers, bool allInclusive) : base(destination, country, numOfTravellers)
    {
        AllInclusive = allInclusive;
    }

    public override string GetInfo()
    {
        return $"Travel to {Country}";
    }

    public override string GetTravelType()
    {
        return "Vacation";
    }

    public override string GetTravelInfo()
    {
        if(AllInclusive)
        {
            return $"All inclusive";
        }
        else
        {
            return "Is not All inculsive";
        }
    }

}
