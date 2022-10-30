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
using System.Windows.Xps;
using TravelPal.Manage;

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for ChangeUsernameWindow.xaml
    /// </summary>
    public partial class ChangeUsernameWindow : Window
    {

        public string NewUsername { get; set; }


        // Constructor
        public ChangeUsernameWindow()
        {
           
            InitializeComponent();            

        }

        // Function for when change username button is click
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string newUsername = txtNewUsername.Text;

            //userManager.SignedInUser.username = newUsername;
            this.NewUsername = newUsername;

            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
