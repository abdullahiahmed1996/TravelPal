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
        UserManager userManager;
        public TravelsWindow(UserManager userManager)
        {
            this.userManager = userManager;
            string[] location = Enum.GetNames(typeof(Countries));
            // cbCountry.ItemsSource = location;

            

            InitializeComponent();

            lblUsername.Content = userManager.SignedInUser.username;



        }

        
        private void btnAddTravel_Click(object sender, RoutedEventArgs e)
        {
            AddTravelWindow addTravelWindow = new();

            addTravelWindow.Show();
        }

        // If the ask botton is click open a pop-up window with a message
        private void btnAsk_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("For more info on how to use the app visite our website:  www.travelpal.com","Info" );

        }

        // When the sig
        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            

            MainWindow mainWindow = new();
            mainWindow.Show();

            Close();

        }

        private void btnUserDetails_Click(object sender, RoutedEventArgs e)
        {
            UserDetailsWindow userDetailsWindow = new();
            userDetailsWindow.Show();
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            TravelDetailsWindow travelDetailsWindow = new();
            travelDetailsWindow.Show(); 

        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
