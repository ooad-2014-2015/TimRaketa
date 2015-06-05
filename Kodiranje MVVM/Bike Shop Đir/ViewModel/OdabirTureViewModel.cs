using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bike_Shop_Đir.Model;
using Bike_Shop_Đir.View;
using System.Windows.Input;
using System.ComponentModel;
using System.Windows;
using Bike_Shop_Đir.View;
using Bike_Shop_Đir.Model;

namespace Bike_Shop_Đir.ViewModel
{
    public class OdabirTureViewModel : INotifyPropertyChanged
    {
        private KatalogTura ture;
        public KatalogTura Ture
        {
            get { return ture; }
            set { ture = value; OnPropertyChanged("Ture"); }
        }

        private GlavnaFormaViewModel parent;
        public GlavnaFormaViewModel Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        public ICommand DodajNovu { get; set; }
        public ICommand OdabirTure { get; set; }

        private string tekstPoruke;
        public string TekstPoruke
        {
            get { return tekstPoruke; }
            set { tekstPoruke = value; OnPropertyChanged("TekstPoruke"); }
        }

        private Tura turaOdabrana;
        public Tura TuraOdabrana
        {
            get { return turaOdabrana; }
            set { turaOdabrana = value; }
        }

        private Tura turaDodana;
        public Tura TuraDodana
        {
            get { return turaOdabrana; }
            set { turaOdabrana = value; }
        }

        private FormaPrikazTure formaPrikazTure;
        public FormaPrikazTure FormaPrikazTure
        {
            get { return formaPrikazTure; }
            set { formaPrikazTure = value; }
        }

        private PrikazTureViewModel prikazTureViewModel;
        public PrikazTureViewModel PrikazTureViewModel
        {
            get { return prikazTureViewModel; }
            set { prikazTureViewModel = value; }
        }

        public OdabirTureViewModel()
        {
            ture = new KatalogTura();
            napuni();
            turaOdabrana = null;
            DodajNovu = new RelayCommand(dodajNovu);
            OdabirTure = new RelayCommand(odabirTure);
        }

        public void dodajNovu(object parameter)
        {
            FormaDodavanjeTure f = new FormaDodavanjeTure(this);
            f.Show();
        }

        public void odabirTure(object parameter)
        {
            //turaOdabrana = selektovanaTura....
            //dodavanje selektovane ture u korpu...

            TekstPoruke = "Prijavili ste se!";
        }

        public void otvori(Tura pTura)
        {
            formaPrikazTure = new FormaPrikazTure();
            prikazTureViewModel = new PrikazTureViewModel(pTura);
            formaPrikazTure.DataContext = prikazTureViewModel;
            if (prikazTureViewModel.CloseAction == null)
                prikazTureViewModel.CloseAction = new Action(() => formaPrikazTure.Close());
            formaPrikazTure.Show();
        }

        //ova funkcija služi samo simulacije radi...kad povežemo sa bazom ona će biti obrisana
        public void napuni()
        {
            Tura t1 = new Tura();
            t1.IDTure = "Sarajevo-Trebevic";
            t1.Duzina = 50;
            t1.Trajanje = 5;
            Ture.TureUPonudi.Add(t1);
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
