using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace girilensayitekciftkontrolu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("Tek çift kontrolü etmek istediğiniz sayıyı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if
                (sayi % 2 == 0)
            {
                Console.WriteLine("Sayınız çift.");
            }
            else
            {
                Console.WriteLine("Sayınız tek.");
            } 
            Console.ReadKey();
              
                    

        }
    }
}
