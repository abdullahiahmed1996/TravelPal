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
using TravelPal.Travel;

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        private UserManager userManager;
        private readonly TravelManager travelManager;
        

        // Costructor
        public RegisterWindow(UserManager userManager, TravelManager travelManager)
        {
            InitializeComponent();

            this.userManager = userManager;
            this.travelManager = travelManager;
            string[] location = Enum.GetNames(typeof(Countries));
            cbCountry.ItemsSource = location;

        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = pswPassword.Password;
            string location = cbCountry.SelectedItem as string;


                //userManager.SignedInUser.username = newUsername;


         
            if (location != null)
            {
                Countries country = (Countries)Enum.Parse(typeof(Countries), location); 
                this.userManager.AddUser(username, password,country);
            }

            Close();
        }
    }
}
