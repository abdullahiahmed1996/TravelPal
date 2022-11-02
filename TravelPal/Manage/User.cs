using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TravelPal.Enums;
using TravelPal.Travels;

namespace TravelPal.Manage;

public  class User:IUser
{
    // Properteis
    public string Username { get; set; }
    public string Password { get; set; }
    public Countries Location { get; set; }

    //public bool isAdmin { get; set; }

    public List<Travel> Travels { get; set; } = new();

    // Constuctor
    public User(string username,string password,Countries location)
    {
        Username = username;
        Password = password;
        Location = location;
    }

}
