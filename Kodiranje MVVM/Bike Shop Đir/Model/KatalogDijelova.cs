using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

namespace Bike_Shop_Đir.Model
{
    public class KatalogDijelova
    {
        private List<DioBicikla> dijeloviUPonudi;
        public List<DioBicikla> DijeloviUPonudi
        {
            get { return dijeloviUPonudi; }
            set { dijeloviUPonudi = value; }
        }
         

        public KatalogDijelova()
        {
           
           // SqlConnection veza = new SqlConnection("Data Source=TOPLAP;Initial Catalog=BikeShopGir;Integrated Security=True");
            dijeloviUPonudi = new List<DioBicikla>();
        }

        void dodajDio(DioBicikla dio)
        {
            
            dijeloviUPonudi.Add(dio);
        }

        
        
        void obrisiDio(string id)
        {

            dijeloviUPonudi.Remove(dijeloviUPonudi.Single(x => x.idDijela == id));
        }
    }
}
