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
using LogikaBiznesowa;

namespace SimpleNicknameGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //OsobaComboBox.Items = moje itemy
            // http://www.youtube.com/watch?v=-ryNYYPalO8
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string[] przymiotniki = System.IO.File.ReadAllLines(@"D:\Learning\SimpleNicknameGenerator/text1.txt", Encoding.Default);
            //string[] rzeczowniki = System.IO.File.ReadAllLines(@"D:\Learning\SimpleNicknameGenerator/text2.txt", Encoding.Default);

            //Random losuj = new Random();
            //int indeksPrzymiotnika = losuj.Next(1, przymiotniki.Length) - 1;
            //int indeksRzeczownika = losuj.Next(1, rzeczowniki.Length) - 1;
            //Ksywka.Text = przymiotniki[indeksPrzymiotnika] + " " + rzeczowniki[indeksRzeczownika];
            Generate generacja = new Generate();
            Ksywka.Text = generacja.GenerateNickname();
        }

        private void OsobaComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(OsobaComboBox.Text))
            {
                Button.IsEnabled = true;
            }
        }
    }
}
