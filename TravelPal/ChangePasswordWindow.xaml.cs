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
using TravelPal.Manage;

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for ChangePasswordWindow.xaml
    /// </summary>
    public partial class ChangePasswordWindow : Window
    {
        private UserManager userManager;
        
        // prop for new password
        public string newPassword { get; set; }


        // Constructor
        public ChangePasswordWindow(UserManager userManager)
        {
            InitializeComponent();
            this.userManager = userManager;

        }

        // Function for when change password button is click
        public void btnChangePassword_Click(object sender, RoutedEventArgs e)
        {
            if(txtNewPassword.Text.Length >= 5)
            {
                string newPassword = txtNewPassword.Text;
                this.newPassword = newPassword;
            }
            else
            {   // Waring message that pops up if the user entered a password that is too short
                MessageBox.Show("The password should be at least 5 characters");
            }

            if(txtNewPassword.Text == txtConfirmPassword.Text)
            {
                string newPassword = txtConfirmPassword.Text;
                this.newPassword = newPassword;
                Close();

            }
            else
            {   // Waring message if the 2 passwords don't match
                MessageBox.Show("The two passwords don't match","Warning!");
            }

        }

        
    }
}
