using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Drawing;
using System.Windows.Forms;
using Bike_Shop_Đir.Model;

namespace Bike_Shop_Đir.ViewModel
{
    public class DodavanjeBiciklaViewModel : INotifyPropertyChanged
    {
        public ICommand KlikDugme { get; set; }

        private Image slika;
        public Image Slika
        {
            get { return slika; }
            set { slika = value; OnPropertyChanged("Slika"); }
        }

        private BicikloPredefinisano novoBiciklo;

        public BicikloPredefinisano NovoBiciklo
        {
            get { return novoBiciklo; }
            set { novoBiciklo = value; }
        }

        public DodavanjeBiciklaViewModel()
        {
            NovoBiciklo = new BicikloPredefinisano();
            KlikDugme = new RelayCommand(klikDugme);

        }

        public void klikDugme(object parameter)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                NovoBiciklo.Slika = new Bitmap(open.FileName);

            }

        }



        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
