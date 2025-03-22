using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satıTahminOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            {
                Random rastgele = new Random();
                int tutulansayi = rastgele.Next(1, 101); // 1 ile 100 arasında sayı tutar
                int tahmin = 0;
                int deneme = 0;

                Console.WriteLine("1 ile 100 arasında bir sayı tuttum. Tahmin etmeye çalış!");

                while (tahmin != tutulansayi)
                {
                    Console.Write("Tahmininizi girin: ");
                    tahmin = Convert.ToInt32(Console.ReadLine());
                    deneme++;

                    if (tahmin < tutulansayi)
                        Console.WriteLine("Daha büyük bir sayı girin!");
                    else if (tahmin > tutulansayi)
                        Console.WriteLine("Daha küçük bir sayı girin!");
                    else
                        Console.WriteLine($"Tebrikler! {deneme} denemede doğru tahmin ettiniz.");
                }
            }
        }

    }
}

