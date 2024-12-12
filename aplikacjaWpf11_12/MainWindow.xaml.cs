using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace aplikacjaWpf11_12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Haslo = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int dlugosc = 0;
            Random random = new Random();
            Haslo = "";
            if (int.TryParse(iloscZnakow_box.Text, out dlugosc))
            {
                if (litery_box.IsChecked == true)
                {
                    string litery = "QWERTYUIOPASDFGHJKLZXCVBNM";
                    int indeks = random.Next(litery.Length);
                    Haslo = Haslo + litery[indeks];
                }
                if (cyfry_box.IsChecked == true)
                {
                    string liczby = "1234567890";
                    int indeks = random.Next(liczby.Length);
                    Haslo = Haslo + liczby[indeks];
                }
                if(znaki_box.IsChecked == true)
                {
                    string znakiSpecjalne = "!@#$%^&*()+-=";
                    int indeks = random.Next(znakiSpecjalne.Length);
                    Haslo = Haslo + znakiSpecjalne[indeks];
                }
                while (Haslo.Length < dlugosc) 
                {
                    string male = "qwertyuiopasdfghjklzxcvbnm";
                    int indeks = random.Next(male.Length);
                    Haslo += male[indeks];
                }
                MessageBox.Show("Haslo to " + Haslo);


            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}