using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using TravelPal.Enums;

namespace TravelPal.Manage;

public interface IUser
{
    // Properties
    public string username { get; set; }
    public string password { get; set; }
    public Countries location { get; set; }

    public bool isAdmin { get; }



    public void IUser(string username, string password, Countries location)
    {

    }
}
