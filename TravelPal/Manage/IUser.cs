using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPal.Enums;

namespace TravelPal.Manage
{
    public interface IUser
    {
        // Properties
        public string username { get; set; }
        public string password { get; set; }

        public Countries location { get; set; }
    }
}
