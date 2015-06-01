﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows;
using System.ComponentModel;
using Bike_Shop_Đir.Model;
using Bike_Shop_Đir.View;

using bsd = Bike_Shop_Đir.View;
using System.Data.Objects.DataClasses;
using System.Windows.Media;


namespace Bike_Shop_Đir.ViewModel
{
    public class RegistracijaViewModel : INotifyPropertyChanged
    {
       private GlavnaFormaViewModel parent;
        public GlavnaFormaViewModel Parent
        {
            get { return parent; }
            set { parent = value; }
        }
 
        public ICommand Registracija { get; set; }
        public ICommand Login { get; set; }

//textblock style za login: 
        private string porukaGreske;
        public string PorukaGreske
        {
            get { return porukaGreske; }
            set
            {
                porukaGreske = value;
                OnPropertyChanged("porukaGreske");
            }
        }

        private object vidljivaGreska;
        public object VidljivaGreska
        {
            get { return vidljivaGreska; }
            set { vidljivaGreska = value;
            OnPropertyChanged("vidljivaGreska");
            }
        }

        private string bojaGreske;
        public string BojaGreske
        {
            get { return bojaGreske; }
            set { bojaGreske = value;
            OnPropertyChanged("BojaGreske");
            }
        }
        
//textblock style za registraciju:

        private string porukaGreske2;
        public string PorukaGreske2
        {
            get { return porukaGreske2; }
            set
            {
                porukaGreske2 = value;
                OnPropertyChanged("porukaGreske2");
            }
        }

        private object vidljivaGreska2;
        public object VidljivaGreska2
        {
            get { return vidljivaGreska2; }
            set
            {
                vidljivaGreska2 = value;
                OnPropertyChanged("vidljivaGreska2");
            }
        }

             
        private Klijent noviKlijent;
        public Klijent NoviKlijent
        {
            get { return noviKlijent; }
            set { noviKlijent = value; }
        }


        public RegistracijaViewModel()
        {
            NoviKlijent = new Klijent();
            Registracija = new RelayCommand(registracijaKlik);
            Login = new RelayCommand(loginKlik);
            
        }


        public void registracijaKlik (object parameter)
        {
            NoviKlijent.upisiUBazu();

            PorukaGreske2 = "Uspjesno ste registrovani!";
            BojaGreske = "Zelena";
            VidljivaGreska2 = Visibility.Visible;

        }

        public void loginKlik(object parameter)
        {
            PorukaGreske = "adshkafjkas";

            VidljivaGreska = Visibility.Hidden;

            if (!NoviKlijent.provjeriPostojanje())
            {
                PorukaGreske = "Neispravan username ili password!";
                VidljivaGreska = Visibility.Visible;
                BojaGreske = "Crvena";

            }
            else
            {
                PorukaGreske = "Prijavljeni ste!";
                BojaGreske = "Zelena";
                VidljivaGreska = Visibility.Visible;
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
