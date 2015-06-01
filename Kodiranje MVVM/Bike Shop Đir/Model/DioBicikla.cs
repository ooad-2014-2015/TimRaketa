using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Bike_Shop_Đir.BazaTableAdapters;
using System.Collections.ObjectModel;
using System.Data.Metadata.Edm;
using System.Drawing;
using System.IO;

namespace Bike_Shop_Đir.Model
{
    public class DioBicikla
    {
        public string idDijela { get; set; }
        string nazivProizvodjaca { get; set; }
        int godinaProizvodnje { get; set; }
        string dodatniOpis { get; set; }
        public float cijenaDijela { get; set; }
        public Image slika_komponente { get; set; }       


        public DioBicikla()
        {
            
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }

        public void staviKomponentu()
        {
         /*   KOMPONENTETableAdapter adapter = new KOMPONENTETableAdapter();
            byte[] slika = imageToByteArray(this.slika_komponente) ;
            adapter.Insert(this.idDijela,slika );
            */

        }
        

    }
}
