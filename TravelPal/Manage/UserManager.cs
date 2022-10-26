using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TravelPal.Enums;

namespace TravelPal.Manage;

public class UserManager
{
    // Make new list with users
    public List<IUser> users = new();
    // Signed in user
    public IUser? SignedInUser { get; set; }





    public bool AddUser(string username,string password,Countries country)
    {
        User user = new(username, password, country);
        user.username = username;
        user.password = password;
        user.location = country;

        users.Add(user);

        return true;

    }

    public List<IUser> GetAllUsers()
    {
        return users;
    }

    public bool SignInUser(string username, string password)
    {
        foreach(User user in users)
        {
            if(user.username == username && user.password == password)
            {
                return true;
            }
        }

        return false;

    } 

    public IUser GetUser(string username)
    {
        foreach(IUser user in users)
        {
            if(user.username == username)
            {
                return user;
            }
            
        }
        return null;
    }

         //public void RemoveUser(IUser)
    //{

    //}

    //public bool UpdateUsername(IUser, string)
    //{

    //}

    //private bool VaidateUsername(username)
    //{

    //}
}