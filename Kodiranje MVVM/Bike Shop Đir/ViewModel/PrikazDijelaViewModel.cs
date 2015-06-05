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
    public class PrikazDijelaViewModel
    {
        private GlavnaFormaViewModel glavna;
        public GlavnaFormaViewModel Glavna
        {
            get { return glavna; }
            set { glavna = value; }
        }

        private  DioBicikla dio;
        public   DioBicikla Dio
        {
            get { return dio; }
            set { dio = value; }
        }

        public ICommand Kupi { get; set; }
        public ICommand Brisi { get; set; }

        public PrikazDijelaViewModel(DioBicikla pDio)
        {
            dio = pDio;
            Kupi = new RelayCommand(kupi);
            Brisi = new RelayCommand(brisi);
        }

        public Action CloseAction { get; set; }

        public void kupi(object parametar)
        {
            CloseAction();
        }

        public void brisi(object parametar)
        {

        }
    }
}
