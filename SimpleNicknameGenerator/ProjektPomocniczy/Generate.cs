using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogikaBiznesowa
{
    public class Generate
    {
        public string GenerateNickname()
        {
            string[] przymiotniki = System.IO.File.ReadAllLines(@"D:\Learning\SimpleNicknameGenerator/text1.txt", Encoding.Default);
            string[] rzeczowniki = System.IO.File.ReadAllLines(@"D:\Learning\SimpleNicknameGenerator/text2.txt", Encoding.Default);

            Random losuj = new Random();
            int indeksPrzymiotnika = losuj.Next(1, przymiotniki.Length) - 1;
            int indeksRzeczownika = losuj.Next(1, rzeczowniki.Length) - 1;
            return przymiotniki[indeksPrzymiotnika] + " " + rzeczowniki[indeksRzeczownika];

        }
    }
}
