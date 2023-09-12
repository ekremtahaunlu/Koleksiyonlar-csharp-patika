using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Bir cümle girin: ");
        string cumle = Console.ReadLine().ToLower(); // Cümleyi küçük harfe çeviriyoruz

        char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
        char[] cumleSesliHarfler = cumle.Where(c => sesliHarfler.Contains(c)).Distinct().OrderBy(c => c).ToArray();

        Console.WriteLine("Cümle içindeki sesli harfler (sıralı):");
        foreach (char sesliHarf in cumleSesliHarfler)
        {
            Console.WriteLine(sesliHarf);
        }
    }
}
