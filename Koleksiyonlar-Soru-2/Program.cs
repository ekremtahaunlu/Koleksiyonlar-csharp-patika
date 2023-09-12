using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[20];

        for (int i = 0; i < 20; i++)
        {
            Console.Write("Sayı girin: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                numbers[i] = number;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
                i--;
            }
        }

        Array.Sort(numbers);

        Console.WriteLine("En büyük 3 sayılar:");
        for (int i = 19; i >= 17; i--)
        {
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine("En küçük 3 sayılar:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        int sumOfLargest3 = numbers[18] + numbers[19] + numbers[17];
        int sumOfSmallest3 = numbers[0] + numbers[1] + numbers[2];

        double averageOfLargest3 = (double)sumOfLargest3 / 3;
        double averageOfSmallest3 = (double)sumOfSmallest3 / 3;

        Console.WriteLine("En büyük 3 sayıların Ortalaması: " + averageOfLargest3);
        Console.WriteLine("En küçük 3 sayıların Ortalaması: " + averageOfSmallest3);

        double totalAverage = (averageOfLargest3 + averageOfSmallest3) / 2;
        Console.WriteLine("Toplam Ortalama: " + totalAverage);
    }
}
