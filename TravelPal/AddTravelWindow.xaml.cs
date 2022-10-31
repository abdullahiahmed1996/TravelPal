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

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for AddTravelWindow.xaml
    /// </summary>
    public partial class AddTravelWindow : Window
    {
       private UserManager userManager;
        private TravelsWindow travelsWindow;
        //public string orginCountry;
        //public string numOfTravels;
      
        public AddTravelWindow(UserManager userManager)
        {
            InitializeComponent();
            this.userManager = userManager;
            
            //txtOrginCountry.Text = orginCountry;
            //txtNumOfTravelers.Text = numOfTravels;
            string[] location = Enum.GetNames(typeof(Countries));
            string[] tripType = Enum.GetNames(typeof(TripTypes));
      
            cbTravelDestination.ItemsSource = location;
            cbTripAlt.ItemsSource = tripType;

            //if (cbTripAlt.SelectedItem == Enum.GetNames(typeof(TripTypes))
            //{
                
            //}
           
        }



        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //if()
            //{

            //}
        }

        private void cbTripAlt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
