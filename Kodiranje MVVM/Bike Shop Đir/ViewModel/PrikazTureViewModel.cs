using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using Bike_Shop_Đir.Model;
using Bike_Shop_Đir.View;

namespace Bike_Shop_Đir.ViewModel
{
    public class PrikazTureViewModel
    {
        private GlavnaFormaViewModel glavna;
        public GlavnaFormaViewModel Glavna
        {
            get { return glavna; }
            set { glavna = value; }
        }

        private Tura tura;
        public Tura Tura
        {
            get { return tura; }
            set { tura = value; }
        }

        public ICommand Kupi { get; set; }
       

        public PrikazTureViewModel(Tura pTura)
        {
            tura = pTura;
            Kupi = new RelayCommand(kupi);
            
        }

        public Action CloseAction { get; set; }

        public void kupi(object parametar)
        {
            CloseAction();
        }
    }
}
