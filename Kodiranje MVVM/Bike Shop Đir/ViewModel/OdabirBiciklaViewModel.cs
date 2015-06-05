using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Bike_Shop_Đir.Model;
using Bike_Shop_Đir.View;
using System.Windows;

namespace Bike_Shop_Đir.ViewModel
{
    public class OdabirBiciklaViewModel : INotifyPropertyChanged
    {
        private KatalogBicikala bicikla;
        public KatalogBicikala Bicikla
        {
            get { return bicikla; }
            set { bicikla = value; OnPropertyChanged("Bicikla"); }
        }

        private KatalogDijelova dijelovi;
        public KatalogDijelova Dijelovi
        {
            get { return dijelovi; }
            set { dijelovi = value; OnPropertyChanged("Dijelovi"); }
        }

        private FormaPrikazItema formaPrikazItema;
        public FormaPrikazItema FormaPrikazItema
        {
            get { return formaPrikazItema; }
            set { formaPrikazItema = value; }
        }

        private PrikazItemaViewModel prikazItemaViewModel;
        public PrikazItemaViewModel PrikazItemaViewModel
        {
            get { return prikazItemaViewModel; }
            set { prikazItemaViewModel = value; }
        }

        private GlavnaFormaViewModel parent;
        public GlavnaFormaViewModel Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        private FormaPrikazDijela formaPrikazDijela;
        public FormaPrikazDijela FormaPrikazDijela
        {
            get { return formaPrikazDijela; }
            set { formaPrikazDijela = value; }
        }

        private PrikazDijelaViewModel prikazDijelaViewModel;
        public PrikazDijelaViewModel PrikazDijelaViewModel
        {
            get { return prikazDijelaViewModel; }
            set { prikazDijelaViewModel = value; }
        }


        public ICommand Otvori { get; set; }

        public ICommand DodajNovoBiciklo { get; set; }

        public OdabirBiciklaViewModel()
        {
            bicikla = new KatalogBicikala();
            dijelovi = new KatalogDijelova();
            //Otvori = new RelayCommand(otvori);
            napuni();
            povuciIzBazeBicikla();
            povuciIzBazeDijelove();
            DodajNovoBiciklo = new RelayCommand(dodajNovoBiciklo);
        }

        //ova će funkcija biti obrisana kad se povežemo sa bazom, sada služi samo za simulaciju rada
        private void napuni()
        {
            BicikloPredefinisano b1 = new BicikloPredefinisano();
            BicikloPredefinisano b2 = new BicikloPredefinisano();
            BicikloPredefinisano b3 = new BicikloPredefinisano();
            BicikloPredefinisano b4 = new BicikloPredefinisano();
            BicikloPredefinisano b5 = new BicikloPredefinisano();

            DioBicikla d1 = new DioBicikla();

            b1.IDBicikla = "Scott Voltage";
            b2.IDBicikla = "GT 2.0";
            b3.IDBicikla = "CUBE Acid";
            b4.IDBicikla = "Canyon Grand";
            b5.IDBicikla = "Wichita Unit XT";

            d1.IDDijela = "Fox amortizer";

            b1.CijenaUsluge = 850;
            b2.CijenaUsluge = 600;
            b3.CijenaUsluge = 900;
            b4.CijenaUsluge = 1500;
            b5.CijenaUsluge = 1500;

            d1.CijenaDijela = 600;

            b1.DodatniOpis = "Ovaj bicikl je odličan za brdsku vožnju jer ima ojačanu opremu. \nTakođer, vrlo je lagan i dobar za duge uspone.";
            b2.DodatniOpis = "Ovaj bicikl je odličan za brdsku vožnju jer ima ojačanu opremu. \nTakođer, vrlo je lagan i dobar za duge uspone.";
            b3.DodatniOpis = "Ovaj bicikl je odličan za brdsku vožnju jer ima ojačanu opremu. \nTakođer, vrlo je lagan i dobar za duge uspone.";
            b4.DodatniOpis = "Ovaj bicikl je odličan za brdsku vožnju jer ima ojačanu opremu. \nTakođer, vrlo je lagan i dobar za duge uspone.";
            b5.DodatniOpis = "Ovaj bicikl je odličan za brdsku vožnju jer ima ojačanu opremu. \nTakođer, vrlo je lagan i dobar za duge uspone.";

            d1.DodatniOpis = "Ovaj amortizer ima hod od 120 mm i veoma je izdržljiv.";

            Bicikla.BiciklaUPonudi.Add(b1);
            Bicikla.BiciklaUPonudi.Add(b2);
            Bicikla.BiciklaUPonudi.Add(b3);
            Bicikla.BiciklaUPonudi.Add(b4);
            Bicikla.BiciklaUPonudi.Add(b5);

            Dijelovi.DijeloviUPonudi.Add(d1);

        }

        public void otvori(BicikloPredefinisano pBajk)
        {
            formaPrikazItema = new FormaPrikazItema();
            prikazItemaViewModel = new PrikazItemaViewModel(pBajk);
            formaPrikazItema.DataContext = prikazItemaViewModel;
            prikazItemaViewModel.Glavna = this.Parent;
            if (prikazItemaViewModel.CloseAction == null)
                prikazItemaViewModel.CloseAction = new Action(() => formaPrikazItema.Close());
            formaPrikazItema.Show();
        }

        public void otvoriDio(DioBicikla pDio)
        {
            formaPrikazDijela = new FormaPrikazDijela();
            prikazDijelaViewModel = new PrikazDijelaViewModel(pDio);
            formaPrikazDijela.DataContext = prikazDijelaViewModel;
            if (prikazDijelaViewModel.CloseAction == null)
                prikazDijelaViewModel.CloseAction = new Action(() => formaPrikazDijela.Close());
            formaPrikazDijela.Show();
        }

        public void povuciIzBazeBicikla()
        {
            //ovdje ćemo u instancu kataloga povući bicikla
        }

        public void povuciIzBazeDijelove()
        {
            //ovdje ćemo u instancukataloga povući dijelove
        }


        public void dodajNovoBiciklo(object parameter)
        {
            FormaDodavanjeBicikla f = new FormaDodavanjeBicikla();
            f.Visibility = Visibility.Visible;
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
