using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TravelPal.Enums;
using TravelPal.Travels;

namespace TravelPal.Manage;

public class UserManager : IUser
{
    // Properties
    public string Username { get; set; }
    public string Password { get; set; }
    public Countries Location { get; set; }
    // Make new list with users
    public List<IUser> Users { get; set; } = new();
    // Signed in user
    public IUser SignedInUser { get; set; }
    
    // Constructor
    public UserManager()
    {
        this.Users = Users;

        AddAdmin();
        AddGandalf();

    }

    private void AddGandalf()// Adding a gandalf user
    {
        User user = new("gandalf", "password", Countries.South_Africa);
        Users.Add(user);

        Trip trip1 = new(TripTypes.Leisure, "Christ the Redeemer", Countries.Brazil,1);
        user.Travels.Add(trip1);

        Vacation vacation1 = new("Mount Kilimanjaro", Countries.Tanzania, 4, true);
        user.Travels.Add(vacation1);
    }

    private void AddAdmin()// Adding a admin user
    {
        Admin admin = new("admin","password",Countries.Japan);
        Users.Add(admin);
    }

    // Add user with new username, password and location
    public bool AddUser(string username,string password,Countries country)
    {
        if(ValidateUsername(username))
        {
            
            {
                User users = new(username, password, country);
                Users.Add(users);
                return true;
            }
        }
        else
        {
            return false;
        }
    }

    // Update the user with this method
    public bool UpdateUsername(IUser user, string username)
    {
        return false;
    }

    // Method to validate the username and to see if that username does excist
    private bool ValidateUsername(string username)
    {
        bool isInavalidUsername = false;

        foreach(IUser user in Users)
        {
            if(user.Username == username)
            {
                isInavalidUsername = true;
            }
        }
        if(!isInavalidUsername)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    //public void RemoveUser(IUser)
    //{

    //}
}