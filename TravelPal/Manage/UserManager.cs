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
    public string Username { get; set; }
    public string Password { get; set; }
    public Countries Location { get; set; }
    // Make new list with users
    public List<IUser> Users { get; set; } = new();
    // Signed in user
    public IUser SignedInUser { get; set; }
    

    public UserManager()
    {
        this.Users = Users;

        AddAdmin();
        AddGandalf();

    }

    private void AddGandalf()//KEEP
    {
        User user = new("gandolf", "password", Countries.South_Africa);
        Users.Add(user);

        Trip trip1 = new(TripTypes.Leisure, "Christ the Redeemer", Countries.Brazil,1);
        user.Travels.Add(trip1);

        Vacation vacation1 = new("Mount Kilimanjaro", Countries.Tanzania, 4, true);
        user.Travels.Add(vacation1);
    }

    private void AddAdmin()//KEEP
    {
        Admin admin = new("admin","password",Countries.Japan);
        Users.Add(admin);
    }

    // Add user with new username, password and location (KEEP)
    public bool AddUser(string username,string password,Countries country)
    {
        if(VaidateUsername(username))
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

    // Make new list with all users
    //public List<IUser> GetAllUsers()
    //{
    //    return Users;
    //}

    //public bool SignInUser(string username, string password)
    //{
    //    // Loop through all users
    //    foreach (User user in Users)
    //    {
    //        // Check is the username and password are the same
    //        if (user.Username == username && user.Password == password)
    //        {
    //            return true;
    //        }
    //    }

    //    return false;

    //}

    // Get users username
    //public IUser GetUser(string username)
    //{
    //    foreach(IUser user in Users)
    //    {
    //        if(user.Username == username)
    //        {
    //            return user;
    //        }
            
    //    }
    //    return null;
    //}

    public bool UpdateUsername(IUser user, string username)//KEEP
    {
        return false;
    }

    private bool VaidateUsername(string username)//KEEP
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