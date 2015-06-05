using Bike_Shop_Đir.ViewModel;
using Bike_Shop_Đir.Model;
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
    /// Interaction logic for FormaOdabirTure.xaml
    /// </summary>
    public partial class FormaOdabirTure : Window
    {
        private OdabirTureViewModel Ot;
        public OdabirTureViewModel OT
        {
            get { return Ot; }
            set { Ot = value; }
        }

        public FormaOdabirTure(bool zaposlenik, bool klijent, GlavnaFormaViewModel g)
        {
            if (zaposlenik)
            {
                button1.Visibility = System.Windows.Visibility.Visible;
            }
            InitializeComponent();
            Ot = new OdabirTureViewModel();
            DataContext = Ot;
        }

        private void DataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            int indeks = datagrid1.SelectedIndex;
            Ot.otvori(Ot.Ture.TureUPonudi[indeks]);
        }
    }
}
