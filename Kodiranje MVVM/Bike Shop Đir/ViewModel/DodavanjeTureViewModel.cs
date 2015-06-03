using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Bike_Shop_Đir.Model;
using Bike_Shop_Đir.ViewModel;

namespace Bike_Shop_Đir.View
{
    public class DodavanjeTureViewModel : INotifyPropertyChanged
    {
        public ICommand DodajTuru { get; set; }

        private Tura novaTura;
        public Tura NovaTura
        {
            get { return novaTura; }
            set { novaTura = value; }
        }

        private OdabirTureViewModel parent;
        public OdabirTureViewModel Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        private string tekstPoruke;
        public string TekstPoruke
        {
            get { return tekstPoruke; }
            set { tekstPoruke = value; OnPropertyChanged("TekstPoruke"); }
        }

        public DodavanjeTureViewModel(OdabirTureViewModel f)
        {
            Parent = f;
            NovaTura = new Tura();
            DodajTuru = new RelayCommand(dodajTuru);
        }


        public void dodajTuru(object parameter)
        {
            this.NovaTura.dodajUBazu();

            this.Parent.TuraDodana = NovaTura;

            TekstPoruke = "Dodali ste novu turu!";

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
