using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace test1
{
    public partial class LoginPage : PhoneApplicationPage
    {
        //username i sifra su predefinisani (a u biti su se oni vec registrovali i postoji u bazi ovaj username i sifra)
        //username: korisnik
        //sifra: 1234
        //validacija se sastoji u tome da ako se pogrijesi nesto od to dvoje nece se pojaviti dugme kupi na formi katalog

        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (username.Text != "korisnik" || sifra.Text != "1234")
            {

                crveniTekst.Text = "Pogrešan username ili šifra";
                crveniTekst.Foreground = new SolidColorBrush(Colors.Black);


            }

            else
            {
                crveniTekst.Text = "Uspješno ste prijavljeni!";
                crveniTekst.Foreground = new SolidColorBrush(Colors.Green);
                MainPage.provjera = true;
            }
        }


    }
}