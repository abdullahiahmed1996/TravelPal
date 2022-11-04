using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        private UserManager userManager;
        private TravelManager travelManager;
        

        // Costructor
        public RegisterWindow(UserManager userManager,TravelManager travelManager)
        {
            InitializeComponent();

            this.userManager = userManager;
            this.travelManager = travelManager;
            
            cbCountry.ItemsSource = Enum.GetNames(typeof(Countries));

        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = pswPassword.Password;
            string country = cbCountry.SelectedItem as string;

            try
            {
                // if either username, password or country is empty show custom message 
                if (username.Count() == 0 || password.Count() == 0 || country.Count() == 0)
                {
                    MessageBox.Show("Please fill in all the information!", "ERROR");

                }
                else
                {
                    Countries selectedCountry = (Countries)Enum.Parse(typeof(Countries),country);

                    if (this.userManager.AddUser(username,password, selectedCountry))
                    {   
                        
                        MainWindow mainWindow = new (userManager,travelManager);
                        mainWindow.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Sorry, this username is already in use. Please use another!");
                    }
                }

            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("ERROR! You didn´t choose a country");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! Fill in all the information");
            }

        }
    }
}
