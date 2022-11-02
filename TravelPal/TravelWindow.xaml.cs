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
using TravelPal.Travels;

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for TravelWindow.xaml
    /// </summary>
    public partial class TravelWindow : Window
    {
        UserManager userManager;
        TravelManager travelManager;
        public TravelWindow(UserManager userManager, TravelManager travelManager)
        {
            string[] location = Enum.GetNames(typeof(Countries));
            // cbCountry.ItemsSource = location;



            InitializeComponent();

            this.userManager = userManager;
            this.travelManager = travelManager;

            lblUsername.Content = userManager.SignedInUser.username;

           
        }

        // Function to open AddTrave window
        private void btnAddTravel_Click(object sender, RoutedEventArgs e)
        {
            AddTravelsWindow addTravelWindow = new(userManager, travelManager);

            addTravelWindow.Show();
        }


        // If the ask botton is click open a pop-up window with a message
        private void btnAsk_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("For more info on how to use the app visite our website:  www.travelpal.com", "Info");

        }

        // When sign-out is clicked open signout and open MainWindow 
        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {


            MainWindow mainWindow = new(userManager, travelManager);
            mainWindow.Show();

            Close();

        }

        // Open UserDetailsWindow
        private void btnUserDetails_Click(object sender, RoutedEventArgs e)
        {
            UserDetailsWindow userDetailsWindow = new(userManager, travelManager);
            userDetailsWindow.Show();

            Close();
        }

        // Open DetailsWindow
        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            TravelDetailWindow travelDetailWindow = new(userManager, travelManager);
            travelDetailWindow.Show();

            Close();

        }

        // Remove function
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
