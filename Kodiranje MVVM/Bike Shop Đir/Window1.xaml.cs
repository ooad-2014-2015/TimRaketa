using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BarcodeLib.BarcodeReader;
using System.IO;
using System.ComponentModel;
using System.Windows.Input;

namespace WPFCSharpWebCam
{
    /// <summary>
    /// Design by Pongsakorn Poosankam
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        WebCam webcam;
        private void mainWindow_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            webcam = new WebCam();
            webcam.InitializeWebCam(ref imgVideo);
        }

        private void bntStart_Click(object sender, RoutedEventArgs e)
        {
            
            webcam.Start();
        }

        private void bntStop_Click(object sender, RoutedEventArgs e)
        {
            webcam.Stop();
        }

        private void bntContinue_Click(object sender, RoutedEventArgs e)
        {
            webcam.Continue();
        }

        private void bntCapture_Click(object sender, RoutedEventArgs e)
        {
            imgCapture.Source = imgVideo.Source;
            

        }

        private void bntSaveImage_Click(object sender, RoutedEventArgs e)
        {
            Helper.SaveImageCapture((BitmapSource)imgCapture.Source);
        }

        private void bntResolution_Click(object sender, RoutedEventArgs e)
        {
            webcam.ResolutionSetting();
        }

        private void bntSetting_Click(object sender, RoutedEventArgs e)
        {
            webcam.AdvanceSetting();
        }

        private void QR_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            string poruka="nesto";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                try
                {
                    string[] nadjeni = Directory.GetFiles(dialog.SelectedPath, "*.png", SearchOption.AllDirectories);
                    string[] slika = BarcodeReader.read(nadjeni[0], BarcodeReader.QRCODE);
                    qrText.Text = slika[0];
                }
                catch (IndexOutOfRangeException)
                {
                    poruka = "prazno";
                   
                }


                if (poruka != "prazno")
                {
                    tekstblok.Text = "Vaš QR kod je tačan.";
                    tekstblok.Foreground = new SolidColorBrush(Colors.ForestGreen);
                }
                else
                {
                    tekstblok.Text = "Login nije uspio";
                    tekstblok.Foreground = new SolidColorBrush(Colors.Red);
                }
                
            }
            
        }
    }
}
