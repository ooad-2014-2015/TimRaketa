using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bike_Shop_Đir.Model;
using Bike_Shop_Đir.View;

namespace Bike_Shop_Đir.ViewModel
{
    public class OdabirTureViewModel
    {
        private KatalogTura ture;
        public KatalogTura Ture
        {
            get { return ture; }
            set { ture = value; }
        }
    }
}
