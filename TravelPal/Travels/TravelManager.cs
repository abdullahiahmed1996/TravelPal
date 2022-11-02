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
    public List<Travel> Travels { get; set; } = new();
    UserManager userManager;

    public Travel AddTravel(string orginDestination, Countries country, int numOfTravellers,TripTypes tripTypes)
    {
        Trip trip = new(tripTypes, orginDestination, country, numOfTravellers);
        Travels.Add(trip);
        return trip;
    }

    public Travel AddTravel(bool allInclusive, string orginDestination, Countries country, int numOfTravellers)
    {
        Vacation vacation = new(orginDestination, country, numOfTravellers, allInclusive);
        Travels.Add(vacation);
        return vacation;
    }

    public void RemoveTravel(Travel travelToRemove)
    {
        if(Travels.Contains(travelToRemove))
        {
            Travels.Remove(travelToRemove);
        }
    }
}
