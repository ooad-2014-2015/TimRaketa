using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace BikeShopDir
{
    public partial class Katalog1 : PhoneApplicationPage
    {
        public Katalog1()
        {
            InitializeComponent();

            using (timRaketaContext db = new timRaketaContext(timRaketaContext.ConnectionString))
            {
                db.CreateIfNotExists();

                Table<Bicikla> bicikla = db.GetTable<Bicikla>();
                var biciklaUpit = from j in bicikla.ToList() select j;
                foreach (var biciklo in biciklaUpit)
                {
                    PivotItem p = new PivotItem();
                    Kontrola1 bikeKontrola = new Kontrola1();
                    bikeKontrola.Cijena.Text = "Cijena: " + biciklo.Cijena + " KM";
                    bikeKontrola.Opis.Text = biciklo.Opis;
                    if (biciklo.Slika.ToArray() != null && biciklo.Slika.ToArray() is Byte[])
                    {
                        MemoryStream stream = new MemoryStream(biciklo.Slika.ToArray());
                        BitmapImage image = new BitmapImage();
                        image.SetSource(stream);
                        bikeKontrola.Slika.Source = image;
                    }
                    p.Header = biciklo.Naziv;
                    p.Content = bikeKontrola;
                    mojPivot.Items.Add(p);

                }

            }
        }

        private void mojPivot_Loaded(object sender, RoutedEventArgs e)
        {
            if (MainPage.provjera)
                kupiDugme.Visibility = Visibility.Visible;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Kupovina.xaml", UriKind.Relative));
        }
    }
}