using System;
namespace Donguler

{
    class Program
    {
        static void Main(String[] args)
        {

            String kurs1 = "Yazılım geliştirici yetiştirme kampı";
            String kurs2 = "Programlamaya başlangıç için temel kurs";
            String kurs3 = "Java";
            String kurs4 = "Python";

            String[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı",
                "Programlamaya başlangıç için temel kurs","Java", "Python" };
            
           for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}