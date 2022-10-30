﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPal.Enums;

namespace TravelPal.Manage;

// Admin class should inherit form IUser
public class Admin : IUser
{
    // Constructor with inputs
    public Admin(string username, string password, Countries location)
    {
        
    }

    // Properties
    public string username { get ; set; }
    public string password { get; set; }
    public Countries location { get; set; }
}
