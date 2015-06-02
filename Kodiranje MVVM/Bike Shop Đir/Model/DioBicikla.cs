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
        private string idDijela;
        public string IDDijela
        {
            get { return idDijela; }
            set { idDijela = value; }
        }

        private string nazivProizvodjaca;
        public string NazivProizvodjaca
        {
            get { return nazivProizvodjaca; }
            set { nazivProizvodjaca = value; }
        }

        private int godinaProizvodnje;
        public int GodinaProizvodnje
        {
            get { return godinaProizvodnje; }
            set { godinaProizvodnje = value; }
        }

        private string dodatniOpis;
        public string DodatniOpis
        {
            get { return dodatniOpis; }
            set { dodatniOpis = value; }
        }

        private Image slikaKomponenete;
        public Image SlikaKomponente
        {
            get { return slikaKomponenete; }
            set { slikaKomponenete = value; }
        }

        private float cijenaDijela;
        public float CijenaDijela
        {
            get { return cijenaDijela; }
            set { cijenaDijela = 0; }
        }


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
