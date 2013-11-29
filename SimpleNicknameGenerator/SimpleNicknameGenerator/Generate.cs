using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNicknameGenerator
{
    class Generate
    {
        public static void GenerateNickname()
        {
            string[] text1 = System.IO.File.ReadAllLines(@"D:\Learning\SimpleNicknameGenerator/text1");
            string[] text2 = System.IO.File.ReadAllLines(@"D:\Learning\SimpleNicknameGenerator/text2");

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

        }
    }
}
