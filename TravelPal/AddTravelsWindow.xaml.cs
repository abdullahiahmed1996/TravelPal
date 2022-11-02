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
    /// Interaction logic for AddTravelsWindow.xaml
    /// </summary>
    public partial class AddTravelsWindow : Window
    {
        private UserManager userManager;
        private TravelManager travelManager;
        private string selectedTravelType;
        public AddTravelsWindow(UserManager userManager, TravelManager travelManager)
        {
            InitializeComponent();

            this.userManager = userManager;
            this.travelManager = travelManager;

            string orginCountry = txtOrginCountry.Text;
            string numOfTravelers = txtNumOfTravellers.Text;

            //txtOrginCountry.Text = orginCountry;
            //txtNumOfTravelers.Text = numOfTravels;
            string[] location = Enum.GetNames(typeof(Countries));
            string[] travelType = Enum.GetNames(typeof(TravelTypes));
            string[] tripType = Enum.GetNames(typeof(TripTypes));

            cbTravelDestination.ItemsSource = location;
            cbTrevelType.ItemsSource = travelType;
            cbTripTypes.ItemsSource = tripType;
        }

        private void btnAddTravel_Click(object sender, RoutedEventArgs e)
        {
            string orginCountry = txtOrginCountry.Text;
            string travelDestination = cbTravelDestination.SelectedItem as string;
            int numberOfTravelers = Convert.ToInt32(txtNumOfTravellers.Text);
            Countries country = (Countries)Enum.Parse(typeof(Countries), travelDestination);

            try
            {
                if (selectedTravelType == "Trip")
                {
                    string tripTypeString = cbTripTypes.SelectedItem as string;

                    TripTypes tripType = (TripTypes)Enum.Parse(typeof(TripTypes), tripTypeString);

                    Travel newTravel = travelManager.AddTravel(orginCountry, country, numberOfTravelers, tripType);

                    if (userManager.SignedInUser is User)
                    {
                        User user = userManager.SignedInUser as User;

                        user.Travels.Add(newTravel);

                        userManager.SignedInUser = user;
                    }
                }
                else if (selectedTravelType == "Vacation")
                {
                    bool allInclusive = (bool)xbAllInclusive.IsChecked;

                    Travel newTravel = travelManager.AddTravel(allInclusive, orginCountry, country, numberOfTravelers);

                    if (userManager.SignedInUser is User)
                    {
                        User user = userManager.SignedInUser as User;

                        user.Travels.Add(newTravel);

                        userManager.SignedInUser = user;
                    }
                }

                TravelWindow travelWindow = new(userManager, travelManager);
                travelWindow.Show();
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cbTrevelType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.selectedTravelType = cbTrevelType.SelectedItem as string;

            try
            {
                if (selectedTravelType == "Trip")
                {
                    cbTripTypes.Visibility = Visibility.Visible;
                    xbAllInclusive.Visibility = Visibility.Hidden;
                }
                else if (selectedTravelType == "Vacation")
                {
                    xbAllInclusive.Visibility = Visibility.Visible;
                    cbTripTypes.Visibility = Visibility.Hidden;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            TravelWindow travelWindow = new(userManager, travelManager);
            travelWindow.Show();
            Close();
        }
    }
}
