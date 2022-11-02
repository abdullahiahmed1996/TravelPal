﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPal.Enums;

namespace TravelPal.Travels;

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

}