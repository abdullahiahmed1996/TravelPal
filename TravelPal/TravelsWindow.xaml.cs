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
    /// Interaction logic for TravelsWindow.xaml
    /// </summary>
    public partial class TravelsWindow : Window
    {
        UserManager userManager = new();
        public TravelsWindow(UserManager userManager)
        {
            this.userManager = userManager;
            string[] location = Enum.GetNames(typeof(Countries));
           // cbCountry.ItemsSource = location;

            InitializeComponent();

            
        }

        private void btnUserTravels_Click(object sender, RoutedEventArgs e)
        {
            UserDetailsWindow userDetailsWindow = new();

            userDetailsWindow.Show();

        }

        private void btnAddTravel_Click(object sender, RoutedEventArgs e)
        {
            AddTravelWindow addTravelWindow = new();

            addTravelWindow.Show();
        }
    }
}
