using System;

namespace HesapMakinesi
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesi");
            Console.WriteLine("----------------");

      
            Console.Write("Birinci sayıyı girin: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

           
            Console.Write("İkinci sayıyı girin: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

          
            Console.WriteLine("Yapmak istediğiniz işlemi seçin (+, -, *, /): ");
            char islem = Convert.ToChar(Console.ReadLine());

            double sonuc = 0;

          
            switch (islem)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    break;
                case '-':
                    sonuc = sayi1 - sayi2;
                    break;
                case '*':
                    sonuc = sayi1 * sayi2;
                    break;
                case '/':
                    if (sayi2 != 0)
                        sonuc = sayi1 / sayi2;
                    else
                        Console.WriteLine("Hata: Bir sayı sıfıra bölünemez!");
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem seçimi!");
                    break;
            }

            if (islem == '+' || islem == '-' || islem == '*' || (islem == '/' && sayi2 != 0))
            {
                Console.WriteLine($"Sonuç: {sonuc}");
            }

            Console.WriteLine("Programı kapatmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
