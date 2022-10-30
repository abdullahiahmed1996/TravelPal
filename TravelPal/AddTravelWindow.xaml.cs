using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TravelPal.Enums;
using TravelPal.Manage;

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for AddTravelWindow.xaml
    /// </summary>
    public partial class AddTravelWindow : Window
    {
        UserManager userManager = new();
        public AddTravelWindow(UserManager userManager)
        {
            InitializeComponent();
            this.userManager = userManager;
            string[] location = Enum.GetNames(typeof(Countries));
            string[] tripType = Enum.GetNames(typeof(TripTypes));
      
            cbTravelDestination.ItemsSource = location;
            cbTriptype.ItemsSource = tripType;

        }
    }
}
