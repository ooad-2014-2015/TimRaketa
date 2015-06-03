using Bike_Shop_Đir.Model;
using Bike_Shop_Đir.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using bsd = Bike_Shop_Đir;

namespace Bike_Shop_Đir.ViewModel
{
    public class GlavnaFormaViewModel : INotifyPropertyChanged
    {
        public ICommand RegistracijaILogovanje { get; set; }
        public ICommand OdabirBicikla { get; set; }
        public ICommand OdabirTure { get; set; }
        public ICommand NarucivanjeServis { get; set; }

        private bool zaposlenikLogovan;
        public bool ZaposlenikLogovan
        {
            get { return zaposlenikLogovan; }
            set { zaposlenikLogovan = value; }
        }

        private bool klijentLogovan;
        public bool KlijentLogovan
        {
            get { return klijentLogovan; }
            set { KlijentLogovan = value; }
        }

        private FormaOdabirBicikla formaOdabirBicikla;
        public FormaOdabirBicikla FormaOdabirBicikla
        {
            get { return formaOdabirBicikla; }
            set { formaOdabirBicikla = value; }
        }

        private OdabirBiciklaViewModel odabirBiciklaViewModel;
        public OdabirBiciklaViewModel OdabirBiciklaViewModel
        {
            get { return odabirBiciklaViewModel; }
            set { odabirBiciklaViewModel = value; }
        }

        private FormaOdabirTure formaOdabirTure;
        public FormaOdabirTure FormaOdabirTure
        {
            get { return formaOdabirTure; }
            set { formaOdabirTure = value; }
        }

        private OdabirTureViewModel odabirTureViewModel;
        public OdabirTureViewModel OdabirTureViewModel
        {
            get { return odabirTureViewModel; }
            set { odabirTureViewModel = value; }
        }

        private FormaNarucivanjeServis formaNarucivanjeServis;
        public FormaNarucivanjeServis FormaNarucivanjeServis
        {
            get { return formaNarucivanjeServis; }
            set { formaNarucivanjeServis = value; }
        }

        private NarucivanjeServisViewModel narucivanjeServisViewModel;
        public NarucivanjeServisViewModel NarucivanjeServisViewModel
        {
            get { return narucivanjeServisViewModel; }
            set { narucivanjeServisViewModel = value; }
        }

        FormaRegistracijaILoginView formaRegistracija;        
        public FormaRegistracijaILoginView FormaRegistracija
        {
            get { return formaRegistracija; }
            set { formaRegistracija = value; }
        }

        private Klijent noviKlijent;
        public Klijent NoviKlijent
        {
            get { return noviKlijent; }
            set { noviKlijent = value; }
        }

        private Zaposlenik zaposlenik;
        public Zaposlenik Zaposlenik
        {
            get { return zaposlenik; }
            set { zaposlenik = value; }
        }
        

        public GlavnaFormaViewModel()
        {
            Zaposlenik = null;
            NoviKlijent = null;
            RegistracijaILogovanje = new RelayCommand(registracijaILogovanjeKlik);
            OdabirBicikla = new RelayCommand(odabirBicikla);
            OdabirTure = new RelayCommand(odabirTure);
            NarucivanjeServis = new RelayCommand(narucivanjeServis);    
        }

        public void registracijaILogovanjeKlik(object parametar)
        {
            FormaRegistracija = new FormaRegistracijaILoginView(this);
            FormaRegistracija.Visibility = Visibility.Visible;
        
        }

        public void odabirBicikla(object parametar)
        {
            azuriraj();
            formaOdabirBicikla = new FormaOdabirBicikla(zaposlenikLogovan, klijentLogovan);
            odabirBiciklaViewModel = new OdabirBiciklaViewModel();
            formaOdabirBicikla.DataContext = odabirBiciklaViewModel;
            formaOdabirBicikla.Show();
        }

        public void odabirTure(object parametar)
        {
            azuriraj();
            formaOdabirTure = new FormaOdabirTure(zaposlenikLogovan, klijentLogovan, this);
            odabirTureViewModel = new OdabirTureViewModel(this);
            formaOdabirTure.DataContext = odabirTureViewModel;
            formaOdabirTure.Show();
        }

        public void azuriraj()
        {
            if (Zaposlenik != null)
                zaposlenikLogovan = true;
            else
                zaposlenikLogovan = false;
            if (NoviKlijent != null)
                klijentLogovan = true;
            else
                klijentLogovan = false;
        }

        public void narucivanjeServis(object parametar)
        {
            formaNarucivanjeServis = new FormaNarucivanjeServis(this);
        //    if (narucivanjeServisViewModel.CloseAction == null)
         //       narucivanjeServisViewModel.CloseAction = new Action(() => formaNarucivanjeServis.Close());
            formaNarucivanjeServis.Show();
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
