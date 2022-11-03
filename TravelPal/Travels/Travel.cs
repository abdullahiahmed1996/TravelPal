﻿using System;
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
    public Countries Country { get; set; }
    public int numOfTravellers { get; set; }
    public string Destination { get; set; }
    
    

    //public int TravelDays { get; set; }

    public Travel(string destination, Countries country, int numOfTravellers)
    {
        this.Destination = destination;
        this.Country = country;
        this.numOfTravellers = numOfTravellers;
    }

    public virtual string GetInfo()
    {
        return $"{Country}";
    }

   public virtual string GetTravelType()
   {
        return "TravelType";
   }

    public virtual string GetTravelInfo()
    {
        return "TravelInfo";
    }
}
