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
    /// Interaction logic for UserDetailsWindow.xaml
    /// </summary>
    public partial class UserDetailsWindow : Window
    {

        private UserManager userManager;
        private readonly TravelManager travelManager;
        public string newUsername;
        private string newPassword;
        private Countries newCountry;

        // Constuctor
        public UserDetailsWindow(UserManager userManager, TravelManager travelManager)
        {
            
            InitializeComponent();

            this.userManager = userManager;
            this.travelManager = travelManager;
            string[] location = Enum.GetNames(typeof(Countries));
            cbNewCountry.ItemsSource = location;

            lblUsername.Content = userManager.SignedInUser.username;
            lblPassword.Content = userManager.SignedInUser.password;
            lblCountry.Content = userManager.SignedInUser.location.ToString();
        }

        // Open the ChangeUsername window
        private void btnChangeUsername_Click(object sender, RoutedEventArgs e)
        {
            ChangeUsernameWindow changeUsernameWindow = new();
            changeUsernameWindow.ShowDialog();

            if(!string.IsNullOrEmpty(changeUsernameWindow.NewUsername))
            {
                newUsername = changeUsernameWindow.NewUsername;
                lblUsername.Content = changeUsernameWindow.NewUsername;
            }
        }

        // Open the ChangePassword window
        private void btnChangePassword_Click(object sender, RoutedEventArgs e)
        {
            ChangePasswordWindow changePasswordWindow = new(userManager);
            changePasswordWindow.ShowDialog();

            if (!string.IsNullOrEmpty(changePasswordWindow.newPassword))
            {
                newPassword = changePasswordWindow.newPassword;
                lblPassword.Content = changePasswordWindow.newPassword;

            }
        }

        // Function that allows the user changes the loction
        private void btnChangeCountry_Click(object sender, RoutedEventArgs e)
        {
            string newCountry = cbNewCountry.SelectedItem.ToString();

            Countries selectedNewCountry = (Countries)Enum.Parse(typeof(Countries), newCountry);

            //userManager.SignedInUser.location = selectedNewCountry;
            this.newCountry = selectedNewCountry;

            lblCountry.Content = cbNewCountry.SelectedItem.ToString();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            //string newContry = cbNewCountry.Text;
            if(!string.IsNullOrEmpty(this.newUsername))
            {
                userManager.SignedInUser.username = newUsername;
            }
            if(!string.IsNullOrEmpty (this.newPassword))
            {
                userManager.SignedInUser.password = newPassword;
            }
            if(this.newCountry != null)
            {
                userManager.SignedInUser.location = newCountry;
            }

            TravelWindow travelWindow = new(userManager,travelManager);
            travelWindow.Show();
            Close();
        }

       

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            

            TravelWindow travelWindow = new(userManager, travelManager);
            travelWindow.Show();
            Close();
        }

       
    }
}
