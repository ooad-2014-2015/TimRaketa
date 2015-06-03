using Bike_Shop_Đir.ViewModel;
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
    /// Interaction logic for FormaDodavanjeTure.xaml
    /// </summary>
    public partial class FormaDodavanjeTure : Window
    {
        public FormaDodavanjeTure(OdabirTureViewModel f)
        {
            InitializeComponent();
            DataContext = new DodavanjeTureViewModel(f);
        }
    }
}
