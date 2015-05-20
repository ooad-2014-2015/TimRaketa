using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows;

namespace Bike_Shop_Đir.ViewModel
{
    class RegistracijaViewModel
    {
        private GlavnaFormaViewModel parent;

        public GlavnaFormaViewModel Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        
        public RegistracijaViewModel(GlavnaFormaViewModel p)
        {
            this.parent = p;
            
        }

        
    }
}
