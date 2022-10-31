using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using TravelPal.Travel;

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for AddTravelWindow.xaml
    /// </summary>
    public partial class AddTravelWindow : Window
    {
        private UserManager userManager;
        private TravelManager travelManager;
        private string selectedTravelType;
        //public string orginCountry;
        //public string numOfTravels;
      
        public AddTravelWindow(UserManager userManager,TravelManager travelManager)
        {
            InitializeComponent();
            this.userManager = userManager;
            this.travelManager = travelManager;

            string orginCountry = txtOrginCountry.Text;
            string numOfTravelers = txtNumOfTravelers.Text;
            
            //txtOrginCountry.Text = orginCountry;
            //txtNumOfTravelers.Text = numOfTravels;
            string[] location = Enum.GetNames(typeof(Countries));
            string[] travelType = Enum.GetNames(typeof(TravelTypes));
            string[] tripType = Enum.GetNames(typeof(TripTypes));
            
            cbTravelDestination.ItemsSource = location;
            cbTrevelType.ItemsSource = travelType;
           
            //if (cbTrevelType.SelectedItem == Enum.GetNames(typeof(TripTypes)))
            //{
            //    string[] travelTipes = Enum.GetNames(typeof(TripTypes));
            //}

        }



        

        private void cbTrevelType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedTravelType = cbTrevelType.SelectedItem as string;

            if(selectedTravelType == "Trip")
            {
                cbTripTypes.Visibility = Visibility.Visible;
                xbAllInclusive.Visibility = Visibility.Hidden;
            }
            else if(selectedTravelType == "Vacation")
            {
                xbAllInclusive.Visibility = Visibility.Hidden;
                cbTripTypes.Visibility = Visibility.Hidden;
            }
        }

        private void btnAddTravel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
