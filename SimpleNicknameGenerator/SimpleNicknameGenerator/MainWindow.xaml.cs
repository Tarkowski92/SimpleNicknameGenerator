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
            string[] text1 = System.IO.File.ReadAllLines(@"D:\Learning\SimpleNicknameGenerator/text1.txt");
            string[] text2 = System.IO.File.ReadAllLines(@"D:\Learning\SimpleNicknameGenerator/text2.txt");

            int a = 0;
            int b = 0;
            foreach (string i in text1)
            {
                a++;
            }
            foreach (string i in text2)
            {
                b++;
            }
            Random losuj = new Random();
            int c = losuj.Next(1, a);
            int d = losuj.Next(1, b);
            Ksywka.Text = text1[c-1] + " " + text2[d-1];
        }
    }
}
