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
    // New list to hold the travels
    public List<Travel> Travels { get; set; } = new();
    UserManager userManager;

    // Constructor
    public Travel AddTravel(string orginDestination, Countries country, int numOfTravellers,TripTypes tripTypes)
    {
        Trip trip = new(tripTypes, orginDestination, country, numOfTravellers);
        Travels.Add(trip);
        return trip;
    }

    // Constructor
    public Travel AddTravel(bool allInclusive, string orginDestination, Countries country, int numOfTravellers)
    {
        Vacation vacation = new(orginDestination, country, numOfTravellers, allInclusive);
        Travels.Add(vacation);
        return vacation;
    }

    // Method that allows one to remove a travel
    public void RemoveTravel(Travel travelToRemove)
    {
        if(Travels.Contains(travelToRemove))
        {
            Travels.Remove(travelToRemove);
        }
    }
}
