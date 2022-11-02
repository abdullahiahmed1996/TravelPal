using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPal.Enums;
using TravelPal.Manage;

namespace TravelPal.Travels;

public class TravelManager
{
    public List<Travel> travels { get; set; } = new();
    UserManager userManager;

    public Travel AddTravel(string orginDestination, Countries country, int numOfTravellers,TripTypes tripTypes)
    {
        Trip trip = new(tripTypes, orginDestination, country, numOfTravellers);
        travels.Add(trip);
        return trip;
    }

    public Travel AddTravel(bool allInclusive, string orginDestination, Countries country, int numOfTravellers)
    {
        Vacation vacation = new(orginDestination, country, numOfTravellers, allInclusive);
        travels.Add(vacation);
        return vacation;
    }

    public void RemoveTravel()
    {

    }
}
