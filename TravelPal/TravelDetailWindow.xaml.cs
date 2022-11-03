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
using TravelPal.Travels;

namespace TravelPal;

/// <summary>
/// Interaction logic for TravelDetailWindow.xaml
/// </summary>
public partial class TravelDetailWindow : Window
{
    private readonly UserManager userManager;
    private readonly TravelManager travelManager;
    private readonly Travel travel;
    public TravelDetailWindow(UserManager userManager, TravelManager travelManager, Travel travel)
    {
        InitializeComponent();
        this.userManager = userManager;
        this.travelManager = travelManager;
        this.travel = travel;   
    }

    private void btnCancel_Click(object sender, RoutedEventArgs e)
    {
        TravelWindow travelWindow = new(userManager, travelManager);
        travelWindow.Show();
        Close();
    }
}
