using Polymorphism;

class Program
{
    static void Main(string[] args)
    {
        BaseGeometrikSekil ucgen = new Ucgen(18, 20);// BaseGeometrikSekil türünde bir üçgen nesnesi oluşturuluyor.
        ucgen.AlanHesapla();

        Console.WriteLine("------------------------------------------");

        BaseGeometrikSekil kare = new Kare(14, 16);// BaseGeometrikSekil türünde bir kare nesnesi oluşturuluyor.
        kare.AlanHesapla();

        Console.WriteLine("------------------------------------------");// BaseGeometrikSekil türünde bir dikdörtgen nesnesi oluşturuluyor.

        BaseGeometrikSekil dıkdortgen = new Dıkdortgen(20, 30);
        dıkdortgen.AlanHesapla();

    }
}
