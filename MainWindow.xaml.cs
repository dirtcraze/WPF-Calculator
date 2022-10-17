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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bokKwadratu.Text = "";
            poleKwadratu.Text = "";
            obwodKwadratu.Text = "";
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            kwadrat.Visibility = Visibility.Visible;
            prostokat.Visibility = Visibility.Hidden;
            trojkat.Visibility = Visibility.Hidden;
            kolo.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            kwadrat.Visibility = Visibility.Hidden;
            prostokat.Visibility = Visibility.Visible;
            trojkat.Visibility = Visibility.Hidden;
            kolo.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            kwadrat.Visibility = Visibility.Hidden;
            prostokat.Visibility = Visibility.Hidden;
            trojkat.Visibility = Visibility.Visible;
            kolo.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            kwadrat.Visibility = Visibility.Hidden;
            prostokat.Visibility = Visibility.Hidden;
            trojkat.Visibility = Visibility.Hidden;
            kolo.Visibility = Visibility.Visible;
        }

        private void obliczKwadrat_TextChanged(object sender, TextChangedEventArgs e)
        {
            double bok;

            if (double.TryParse(bokKwadratu.Text, out bok) && bok >= 0)
            {
                poleKwadratu.Text = Math.Pow(bok, 2).ToString();
                obwodKwadratu.Text = (bok * 4).ToString();
                error.Content = "";
            }
            else
            {
                error.Content = "Podaj prawidłowe dane!";
            }
        }

        private void obliczProstokat_TextChanged(object sender, TextChangedEventArgs e)
        {
            double bokA, bokB;

            if (double.TryParse(bokAProstokatu.Text, out bokA) && double.TryParse(bokBProstokatu.Text, out bokB) && bokA >= 0 && bokB >= 0)
            {
                poleProstokatu.Text = (bokA * bokB).ToString();
                obwodProstokatu.Text = (2 * bokA + 2 * bokB).ToString();
                error.Content = "";
            }
            else
            {
                error.Content = "Podaj prawidłowe dane!";
            }
        }

        private void obliczTrojkat_TextChanged(object sender, TextChangedEventArgs e)
        {
            double podstawaTroj, wysokoscTroj;

            if (double.TryParse(podstawaTrojkata.Text, out podstawaTroj) && double.TryParse(wysokoscTrojkata.Text, out wysokoscTroj) && podstawaTroj >= 0 && wysokoscTroj >= 0)
            {
                poleTrojkata.Text = ((podstawaTroj * wysokoscTroj) /2).ToString();
                error.Content = "";
            }
            else
            {
                error.Content = "Podaj prawidłowe dane!";
            }
        }

        private void obliczKolo_TextChanged(object sender, TextChangedEventArgs e)
        {
            double promKola;
            const double PI = 3.141592;

            if (double.TryParse(promienKola.Text, out promKola) && promKola >= 0)
            {
                poleKola.Text = (PI * Math.Pow(promKola, 2)).ToString();
                obwodKola.Text = (2 * PI * promKola).ToString();
                error.Content = "";
            }
            else
            {
                error.Content = "Podaj prawidłowe dane!";
            }
        }
    }
}
