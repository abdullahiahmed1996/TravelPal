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
        Travel travel;

        public TravelWindow(UserManager userManager, TravelManager travelManager)
        {
            string[] location = Enum.GetNames(typeof(Countries));
            // cbCountry.ItemsSource = location;



            InitializeComponent();

            this.userManager = userManager;
            this.travelManager = travelManager;

            lblUsername.Content = userManager.SignedInUser.Username;

            UpdateWindow();

           
        }

        private void UpdateWindow()
        {
            lvDisplay.Items.Clear();

            if(this.userManager.SignedInUser is User)
            {
                User signedInUser = this.userManager.SignedInUser as User;

                foreach(var travel in signedInUser.Travels)
                {
                    ListViewItem item = new();
                    item.Content = travel.GetInfo;
                    item.Tag = travel;
                    lvDisplay.Items.Add(item);
                }
            }
            else if(this.userManager.SignedInUser is Admin)
            {
                IUser signedInAdmin = this.userManager.SignedInUser as Admin;

                foreach(var travel in travelManager.Travels)
                {
                    ListViewItem item = new();
                    item.Content = travel.GetInfo();
                    item.Tag = travel;
                    lvDisplay.Items.Add(item);
                }
            }
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
            ListViewItem selectedItem = lvDisplay.SelectedItem as ListViewItem;

            if (selectedItem != null)
            {
                Travel selectedTravel = selectedItem.Tag as Travel;
                TravelDetailWindow travelDetailWindow = new TravelDetailWindow(userManager,travelManager,travel);
                travelDetailWindow.Show();
            }
            else
            {
                MessageBox.Show("Fill in a selected travel!");
            }
           

            Close();

        }

        // Remove function
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            ListViewItem selectedItem = lvDisplay.SelectedItem as ListViewItem;

            if(selectedItem != null)
            {
                Travel selectedTravel = selectedItem.Tag as Travel;

                travelManager.RemoveTravel(selectedTravel);


                if(userManager.SignedInUser is User)
                {
                    User signedInUser = userManager.SignedInUser as User;
                    signedInUser.Travels.Remove(selectedTravel);
                    userManager.SignedInUser = signedInUser;
                }
            }
 
            else
            {
                MessageBox.Show("Fill in a travel type!");
            }
        }

        private void lvDisplay_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnRemove.IsEnabled = true;
            btnDetails.IsEnabled = true;
        }
    }
}
