using System;


public abstract class Calisan
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Departman { get; set; }

    
    public abstract void Gorev();
}


public class YazilimGelistirici : Calisan
{
    public override void Gorev()
    {
        Console.WriteLine($"{Ad} {Soyad} yazılım geliştirici olarak çalışıyorum.");
    }
}


public class ProjeYoneticisi : Calisan
{
    public override void Gorev()
    {
        Console.WriteLine($"{Ad} {Soyad} proje yöneticisi olarak çalışıyorum.");
    }
}


public class SatisTemsilcisi : Calisan
{
    public override void Gorev()
    {
        Console.WriteLine($"{Ad} {Soyad} satış temsilcisi olarak çalışıyorum.");
    }
}

class Program
{
    static void Main()
    {
        YazilimGelistirici yazilimci = new YazilimGelistirici { Ad = "Jude", Soyad = "Fawley", Departman = "IT" };
        ProjeYoneticisi yonetici = new ProjeYoneticisi { Ad = "Martin", Soyad = "Eden", Departman = "Proje Yönetimi" };
        SatisTemsilcisi satici = new SatisTemsilcisi { Ad = "Sue", Soyad = "Su", Departman = "Satış" };

        yazilimci.Gorev();   
        yonetici.Gorev();    
        satici.Gorev();     
    }
}