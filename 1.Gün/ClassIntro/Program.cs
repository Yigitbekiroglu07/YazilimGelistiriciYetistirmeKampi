using System;
namespace ClassIntro;

class Program
{
    static void Main(String[] args)
    {
        String name = "Yiğit";
        int yas = 36;
        Kurs kurs1 = new Kurs();
        kurs1.KursAdı = "C#";
        kurs1.Eğitmen = "Engin Demiroğ";
        kurs1.İzlenmeOranı = 68;

        Kurs kurs2 = new Kurs();
        kurs2.KursAdı = "Java";
        kurs2.Eğitmen = "Kerem ";
        kurs2.İzlenmeOranı = 72;

        Kurs kurs3 = new Kurs();
        kurs3.KursAdı = "Pyhton";
        kurs3.Eğitmen = "Berkay";
        kurs3.İzlenmeOranı = 80;

        //Console.WriteLine(kurs1.KursAdı + ":" + kurs1.Eğitmen);
        Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
        foreach (Kurs kurs in kurslar)
        {
            Console.WriteLine(kurs.KursAdı + " : " + kurs.Eğitmen);
        }

    }
}

class Kurs
{
    public string KursAdı { get; set; }
    public string Eğitmen { get; set; }

    public int İzlenmeOranı { get; set; }
}