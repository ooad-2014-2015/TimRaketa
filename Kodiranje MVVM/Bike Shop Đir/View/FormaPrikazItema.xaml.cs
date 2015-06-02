﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Bike_Shop_Đir.View
{
    /// <summary>
    /// Interaction logic for FormaPrikazItema.xaml
    /// </summary>
    public partial class FormaPrikazItema : Window
    {
        public FormaPrikazItema(bool zaposlenik, bool klijent)
        {
            if (zaposlenik)
            {
                button1.Visibility = System.Windows.Visibility.Visible;
            }
            if (klijent)
            {
                button2.Visibility = System.Windows.Visibility.Visible;
            }
            InitializeComponent();
        }
    }
}
