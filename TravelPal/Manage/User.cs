using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TravelPal.Enums;

namespace TravelPal.Manage
{
    public  class User:IUser
    {
        //List<Travel> travels = new();

        // Constuctor
        public User(string username,string password,Countries location)
        {

        }

        // Props
        public string username { get; set; }
        public string password { get; set; }
        public Countries location { get; set; }
    }
}
