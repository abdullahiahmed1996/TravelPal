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
    /// Interaction logic for UserDetailsWindow.xaml
    /// </summary>
    public partial class UserDetailsWindow : Window
    {

        private UserManager userManager;

        public UserDetailsWindow(UserManager userManager)
        {
            
            InitializeComponent();

            this.userManager = userManager;
            string[] location = Enum.GetNames(typeof(Countries));
            cbNewCountry.ItemsSource = location;

            lblUsername.Content = userManager.SignedInUser.username;
            lblPassword.Content = userManager.SignedInUser.password;
            lblCountry.Content = userManager.SignedInUser.location.ToString();

           
        }

        private void btnChangeUsername_Click(object sender, RoutedEventArgs e)
        {
            ChangeUsernameWindow changeUsernameWindow = new(userManager);
            changeUsernameWindow.Show();
        }

        private void btnChangePassword_Click(object sender, RoutedEventArgs e)
        {
            ChangePasswordWindow changePasswordWindow = new(userManager);
            changePasswordWindow.Show();
        }

        private void btnChangeCountry_Click(object sender, RoutedEventArgs e)
        {
            string newCountry = cbNewCountry.Text;

            Countries selectedNewCountry = (Countries)Enum.Parse(typeof(Countries), newCountry);

            userManager.SignedInUser.location = selectedNewCountry;

            UserDetailsWindow userDetailsWindow = new(userManager);
            userDetailsWindow.Show();
            Close();
        }
    }
}
