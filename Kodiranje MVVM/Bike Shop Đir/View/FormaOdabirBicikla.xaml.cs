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

namespace Bike_Shop_Đir.View
{
    /// <summary>
    /// Interaction logic for FormaOdabirBicikla.xaml
    /// </summary>
    public partial class FormaOdabirBicikla : Window
    {
        public FormaOdabirBicikla(bool zaposlenik, bool klijent)
        {
            if(zaposlenik)
            {
                button1.Visibility = System.Windows.Visibility.Visible;
                button2.Visibility = System.Windows.Visibility.Visible;
            }
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
    }
}
