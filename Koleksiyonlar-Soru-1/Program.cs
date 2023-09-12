using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        if (number <= 3)
            return true;
        if (number % 2 == 0 || number % 3 == 0)
            return false;

        for (int i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        List<int> asalSayilar = new List<int>();
        List<int> asalOlmayanSayilar = new List<int>();

        int pozitifSayiSayisi = 0;

        while (pozitifSayiSayisi < 20)
        {
            Console.Write("Pozitif bir sayı girin: ");
            if (int.TryParse(Console.ReadLine(), out int sayi) && sayi > 0)
            {
                pozitifSayiSayisi++;

                if (IsPrime(sayi))
                {
                    asalSayilar.Add(sayi);
                }
                else
                {
                    asalOlmayanSayilar.Add(sayi);
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir sayı girin.");
            }
        }

        asalSayilar.Sort((a, b) => b.CompareTo(a));
        asalOlmayanSayilar.Sort((a, b) => b.CompareTo(a));

        Console.WriteLine("Asal Sayılar:");
        foreach (int sayi in asalSayilar)
        {
            Console.WriteLine(sayi);
        }

        Console.WriteLine("Asal Olmayan Sayılar:");
        foreach (int sayi in asalOlmayanSayilar)
        {
            Console.WriteLine(sayi);
        }

        Console.WriteLine("Asal Sayıların Eleman Sayısı: " + asalSayilar.Count);
        Console.WriteLine("Asal Sayıların Ortalaması: " + asalSayilar.Average());

        Console.WriteLine("Asal Olmayan Sayıların Eleman Sayısı: " + asalOlmayanSayilar.Count);
        Console.WriteLine("Asal Olmayan Sayıların Ortalaması: " + asalOlmayanSayilar.Average());
    }
}
