using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace miejsce_0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        double x = 0;
        double dokladnosc =0;
        double pocz=0;
        double koniec=0;
        int krok = 0;

        private void btnLicz_Click(object sender, RoutedEventArgs e)
        {
            miejsce_0();
        }

        private void miejsce_0()
        {
            dokladnosc = Convert.ToDouble(txtDokladnosc.Text);
            pocz = Convert.ToDouble(txtZakresPocz.Text);
            koniec = Convert.ToDouble(txtZakresKon.Text);
            while (Math.Abs(pocz - koniec) > dokladnosc)
            {
                x = (pocz + koniec) / 2;
                krok++;

                if (funkcja(x)*funkcja(pocz) < 0)
                {
                    koniec = x;
                }
                else if (funkcja(x) * funkcja(koniec) < 0)
                {
                    pocz = x;
                }
            }
            txtMiejsce.Text = "miejsce 0 " + x.ToString() +"\n liczba iteracji "+ krok.ToString();
        }

        private double funkcja(double x)
        {
           return ((x - 900) * Math.Pow(Math.E, (-x / 500)) * Math.Sin(x / 100));
            
        }


    }
}
