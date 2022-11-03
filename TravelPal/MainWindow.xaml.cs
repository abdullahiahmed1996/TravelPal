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
using TravelPal.Travels;

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserManager userManager;
        TravelManager travelManager;

        // Constructor no.1
        public MainWindow()
        {
            InitializeComponent();

            this.userManager = new();
            this.travelManager = new();

            foreach (IUser user in userManager.Users)
            {
                if(user is User)
                {
                    User u = user as User;
                    travelManager.Travels.AddRange(u.Travels);
                }
            }

        }
        //Constructor no.2
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
            Close();

        }

        // Function for when signin button is click
        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = pswPassword.Password;
            bool isFoundUser = false;

            foreach(IUser user in userManager.Users)
            {
                if(user.Username == username && user.Password == password)
                {// log in

                    isFoundUser = true;
                    userManager.SignedInUser = user;

                    TravelWindow travelWindow = new(userManager,travelManager);
                    travelWindow.Show();
                    Close();            
                }

                    // If username or password was incorrect show a message box
                if(!isFoundUser)
                {
                     MessageBox.Show("Username or password is incorrect", "Warning");
                }

            }
           
        }
    }
}
