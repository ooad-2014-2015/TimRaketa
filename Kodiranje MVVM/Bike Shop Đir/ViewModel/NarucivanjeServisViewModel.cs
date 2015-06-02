using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using Bike_Shop_Đir.Model;
using Bike_Shop_Đir.View;
using System.Windows.Input;
using System.ComponentModel;

namespace Bike_Shop_Đir.ViewModel
{
    public class NarucivanjeServisViewModel : INotifyPropertyChanged
    {
        private GlavnaFormaViewModel parent;
        public GlavnaFormaViewModel Parent
        {
            get { return parent; }
            set { parent = value; }
        }
        

        private Servis servis;
        public Servis Servis
        {
            get { return servis; }
            set { servis = value; OnPropertyChanged("Servis"); }
        }

        public ICommand Naruci { get; set; }

        private string poruka;
        public string Poruka
        {
            get { return poruka; }
            set
            {
                poruka = value;
                OnPropertyChanged("Poruka");
            }
        }

        public NarucivanjeServisViewModel(GlavnaFormaViewModel g)
        {
            Parent = g;
            Poruka = "";
            servis = new Servis();
            Naruci = new RelayCommand(naruci);
        }

        public Action CloseAction { get; set; }




        public void naruci(object parametar)
        {
            Servis.upisiUBazu();
            Poruka = "Rezervisali ste termin za servis!";
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
