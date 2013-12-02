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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] przymiotniki = System.IO.File.ReadAllLines(@"D:\Learning\SimpleNicknameGenerator/text1.txt");
            string[] rzeczowniki = System.IO.File.ReadAllLines(@"D:\Learning\SimpleNicknameGenerator/text2.txt");

            Random losuj = new Random();
            int indeksPrzymiotnika = losuj.Next(1, przymiotniki.Length) - 1;
            int indeksRzeczownika = losuj.Next(1, rzeczowniki.Length) - 1;
            Ksywka.Text = przymiotniki[indeksPrzymiotnika] + " " + rzeczowniki[indeksRzeczownika];
        }
    }
}
