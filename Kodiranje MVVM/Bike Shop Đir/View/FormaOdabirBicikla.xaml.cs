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

using Bike_Shop_Đir.Model;
using Bike_Shop_Đir.ViewModel;


namespace Bike_Shop_Đir.View
{
    /// <summary>
    /// Interaction logic for FormaOdabirBicikla.xaml
    /// </summary>
    public partial class FormaOdabirBicikla : Window
    {
        bool zaposlenik;
        bool klijent;

        private OdabirBiciklaViewModel Ob;
        public OdabirBiciklaViewModel OB
        {
            get { return Ob; }
            set { Ob = value; }
        }

        public FormaOdabirBicikla(bool pzaposlenik, bool pklijent)
        {
            zaposlenik = pzaposlenik;
            klijent = pklijent;
            if(pzaposlenik)
            {
                button1.Visibility = System.Windows.Visibility.Visible;
                button2.Visibility = System.Windows.Visibility.Visible;
            }
            InitializeComponent();
            Ob = new OdabirBiciklaViewModel();
            DataContext = Ob;
        }

        private void DataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            int indeks = datagrid1.SelectedIndex;
            Ob.otvori(Ob.Bicikla.BiciklaUPonudi[indeks]);
       
        }

        private void DataGrid_SelectedCellsChanged_1(object sender, SelectedCellsChangedEventArgs e)
        {
            int indeks = datagrid2.SelectedIndex;
            Ob.otvoriDio(Ob.Dijelovi.DijeloviUPonudi[indeks]);
        }

        private void datagrid2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
  
    }
}
