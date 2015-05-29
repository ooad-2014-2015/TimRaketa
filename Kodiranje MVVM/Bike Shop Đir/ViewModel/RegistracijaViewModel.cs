using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows;
using System.ComponentModel;
using Bike_Shop_Đir.Model;
using Bike_Shop_Đir.View;

namespace Bike_Shop_Đir.ViewModel
{
    internal class RegistracijaViewModel : INotifyPropertyChanged
    {
       private GlavnaFormaViewModel parent;
        public GlavnaFormaViewModel Parent
        {
            get { return parent; }
            set { parent = value; }
        }
 

        public ICommand Registracija { get; set; }

       

        public ICommand Login { get; set; }



         
        public RegistracijaViewModel(GlavnaFormaViewModel g)
        {
            this.parent = g;
            Registracija = new RelayCommand(registracijaKlik);
            Login = new RelayCommand(loginKlik);
            parent.NoviKlijent = new Klijent();
        }


        public void registracijaKlik (object parameter)
        {
            parent.NoviKlijent.upisiUBazu();

        }

        public void loginKlik(object parameter)
        {
            if (!parent.NoviKlijent.provjeriPostojanje())
            {
                parent.NoviKlijent = null;
                //prijava greske na labeli - nemoguce saznati kako -.-
            }
            else
            {

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
