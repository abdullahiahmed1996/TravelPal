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

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserManager userManager;

        public MainWindow()
        {
            InitializeComponent();

            userManager = new();
        }
        public MainWindow(UserManager userManager)
        {
            InitializeComponent();

            this.userManager = userManager;
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new(userManager);

            registerWindow.Show();

        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = pswPassword.Password;

           if(userManager.SignInUser(username, password))
            {
                userManager.SignedInUser =  userManager.GetUser(username);
                // log in
                TravelsWindow travelsWindow = new(userManager);
                travelsWindow.Show();
                Close();
            }
           else
            {
                MessageBox.Show("Username or password is incorrect", "Warning");

            }
        }
    }
}
