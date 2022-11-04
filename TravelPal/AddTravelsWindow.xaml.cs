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

namespace TravelPal;

/// <summary>
/// Interaction logic for AddTravelsWindow.xaml
/// </summary>
public partial class AddTravelsWindow : Window
{
    private UserManager userManager;
    private TravelManager travelManager;
    private string selectedTravelType;
    // Constuctor
    public AddTravelsWindow(UserManager userManager, TravelManager travelManager)
    {
        InitializeComponent();

        this.userManager = userManager;
        this.travelManager = travelManager;

        string[] location = Enum.GetNames(typeof(Countries));
        cbCountry.ItemsSource = location;

        string orginCountry = txtDestination.Text;

        string numOfTravelers = txtNumOfTravellers.Text;

        
        string[] travelType = Enum.GetNames(typeof(TravelTypes));
        cbTrevelType.ItemsSource = travelType;

        string[] tripType = Enum.GetNames(typeof(TripTypes));
        cbTripTypes.ItemsSource = tripType;
    }

    // Add travel button´s function
    private void btnAddTravel_Click(object sender, RoutedEventArgs e)
    {
        string travelDestination = cbCountry.SelectedItem as string;
        Countries country = (Countries)Enum.Parse(typeof(Countries), travelDestination);

        string orginCountry = txtDestination.Text;
        
        int numberOfTravelers = Convert.ToInt32(txtNumOfTravellers.Text);
        

        try
        {
            if (selectedTravelType == "Trip") // check if the selected travel type is a trip
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
            else if (selectedTravelType == "Vacation") // check if the selected travel type is a trip
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
