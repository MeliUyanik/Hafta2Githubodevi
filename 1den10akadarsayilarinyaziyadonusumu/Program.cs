using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1den10akadarsayilarinyaziyadonusumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.Write("1 ile 10 arasında bir sayı girin: ");
           int sayi = int.Parse(Console.ReadLine());
           string sonuc = sayiyazi(sayi);
           Console.WriteLine(sonuc); 
           Console.ReadKey();
        }
        static string sayiyazi(int sayi)
        {
            switch (sayi)
            {
                case 1: return "BİR";
                case 2: return "İKİ";
                case 3: return "ÜÇ";
                case 4: return "DÖRT";
                case 5: return "BEŞ";
                case 6: return "ALTI";
                case 7: return "YEDİ";
                case 8: return "SEKİZ";
                case 9: return "DOKUZ";
                case 10: return "ON";
                default: return "Geçersiz Sayı";
            }
        }
    }
}