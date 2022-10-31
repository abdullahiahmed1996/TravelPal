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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TravelPal.Enums;
using TravelPal.Manage;
using TravelPal.Travel;

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserManager userManager;
        TravelManager travelManager;

        // Constructor
        public MainWindow()
        {
            InitializeComponent();

            UserManager userManager = new();
            TravelManager travelManager = new();
        }
        //Constructor
        public MainWindow(UserManager userManager, TravelManager travelManager)
        {
            InitializeComponent();

            this.userManager = userManager;
            this.travelManager = travelManager;
        }

        // Function for when register button is click
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new(userManager,travelManager);

            registerWindow.Show();

        }

        // Function for when signin button is click
        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = pswPassword.Password;
            
            
           if(userManager.SignInUser(username, password))
            {
                userManager.SignedInUser =  userManager.GetUser(username);
                // log in
                TravelsWindow travelsWindow = new(userManager,travelManager);
                travelsWindow.Show();
                Close();
            }

           // If username or password was incorrect show a message box
           else
            {
                MessageBox.Show("Username or password is incorrect", "Warning");

            }
        }
    }
}
