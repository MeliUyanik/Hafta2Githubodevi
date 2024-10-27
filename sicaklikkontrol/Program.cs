using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicaklikkontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hava durumu derecesini giriniz: ");
            int derece = int.Parse(Console.ReadLine());
            if (derece >= 10 && derece <= 20)
            {
                Console.WriteLine("Hava normal.");
            }
            else if (derece > 20 && derece <= 30)
            {
                Console.WriteLine("Hava sıcak.");
            }
            else if (derece > 30 && derece <= 40)
            {
                Console.WriteLine("Hava çok sıcak");
            }           
            Console.ReadKey();
        }
    }
}
